//#define _UNICODE
#include <Windows.h>
#include "resource.h"
#include <tchar.h>

/*
1. Написать приложение, позволяющее вывести на экран краткое резюме с помощью последовательности окон сообщений (количество окон сообщений — не менее трёх).
На заголовке последнего окна сообщения должно отобразиться среднее число символов на странице (общее число символов в резюме поделить на количество окон сообщений).
*/



// Global variables:
HINSTANCE hInst;
HWND hButton1, hButton3;
WNDCLASSEX wcl;

// Functions prototypes:
BOOL CALLBACK DlgProc(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam);

// Main Function:
int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpszCmdLine, int nCmdShow)
{
	return DialogBox(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, DlgProc);
}

// Functions defenitions:
BOOL CALLBACK DlgProc(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	switch (message)
	{
	case WM_INITDIALOG:
	{
		wcl.style = CS_HREDRAW | CS_VREDRAW | CS_DBLCLKS;
		hButton1 = GetDlgItem(hDlg, IDC_BUTTON1);
		hButton3 = GetDlgItem(hDlg, IDC_BUTTON3);
		return TRUE;
	}
	case WM_MOUSEMOVE:
	{
		TCHAR str[50];
		wsprintf(str, TEXT("X=%d  Y=%d"), LOWORD(lParam), HIWORD(lParam)); // текущие координаты курсора мыши            
		SetWindowText(hButton3, str); // строка выводится в заголовок окна     

	}
	break;
	case WM_LBUTTONDBLCLK:
	{
		MessageBox(hDlg, _TEXT("_/*o*\\_"), _TEXT("Left button double clicked"), MB_OK | MB_ICONINFORMATION);
	}
	case WM_COMMAND:
	{
		if (LOWORD(wParam) == IDC_BUTTON1)
		{
			BOOL loop = IDRETRY;
			TCHAR firstMsgB[] = _TEXT("First window");
			TCHAR secondMsgB[] = _TEXT("Second window");
			TCHAR header[] = _TEXT("Head");
			TCHAR body[] = _TEXT("Retry?");
			long letterCount = 0;
			long index = 0;

			if (MessageBox(hDlg, firstMsgB, header, MB_OK | MB_ICONQUESTION) == IDOK)
			{
				letterCount += lstrlen(firstMsgB);
				letterCount += wcslen(header);
				index++;

				if (MessageBox(hDlg, secondMsgB, header, MB_OK | MB_ICONQUESTION) == IDOK)
				{
					letterCount += lstrlen(secondMsgB);
					letterCount += wcslen(header);
					index++;

					do
					{
						letterCount += lstrlen(body);
						letterCount += wcslen(header);
						index++;
						loop = MessageBox(hDlg, body, header, MB_RETRYCANCEL | MB_ICONQUESTION);
					} while (loop == IDRETRY);

					if (loop == IDCANCEL || loop == IDABORT)
					{
						double average = letterCount / index;
						char buffer[26];
						_gcvt_s(buffer, sizeof(buffer), average, 17);
						wchar_t answer[26];
						mbstowcs_s(NULL, answer, sizeof(answer) / 2, buffer, sizeof(buffer));

						MessageBox(hDlg, _TEXT("Greetings"), answer, MB_OK | MB_ICONINFORMATION);
					}
				}
			}
		}
		return TRUE;
	}
	case WM_CLOSE:
		EndDialog(hDlg, 0);
		return TRUE;
	}
	return FALSE;
}

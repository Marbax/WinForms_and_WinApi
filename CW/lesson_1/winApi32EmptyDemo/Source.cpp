#define _UNICODE
#include <Windows.h>
#include "resource.h"

// Global variables:
HINSTANCE hInst;
HWND hEdit1, hEdit2;
HWND hButton1, hButton2;

// Functions prototypes:
BOOL CALLBACK DlgProc(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam);

// Main Function:
int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpszCmdLine, int nCmdShow)
{
	hInst = hInstance;
	return DialogBox(hInst, MAKEINTRESOURCE(IDD_DIALOG1), NULL, DlgProc);
}

// Functions defenitions:
BOOL CALLBACK DlgProc(HWND hDlg, UINT message, WPARAM wParam, LPARAM lParam)
{
	switch (message)
	{
	case WM_INITDIALOG:
	{
		hEdit1 = GetDlgItem(hDlg, IDC_EDIT1);
		hEdit2 = GetDlgItem(hDlg, IDC_EDIT2);
		hButton1 = GetDlgItem(hDlg, IDC_BUTTON1);
		hButton2 = GetDlgItem(hDlg, IDC_BUTTON2);
		return TRUE;
	}
	case WM_COMMAND:
	{
		if (LOWORD(wParam) == IDC_BUTTON1)
		{
			MessageBox(hDlg, "Calc", "Test1", MB_OK | MB_ICONINFORMATION);
		}
		else if (LOWORD(wParam) == IDC_BUTTON2)
		{
			MessageBox(hDlg, "Reset", "Test2", MB_OK | MB_ICONINFORMATION);
		}
		return TRUE;
	}
	case WM_CLOSE:
		EndDialog(hDlg, 0);
		return TRUE;
	}
	return FALSE;
}

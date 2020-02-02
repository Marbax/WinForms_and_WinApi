# WinForms_and_WinApi
 WinForms and WinApi lessons repository

<details><summary> 1. WinAPI </summary><p>

---

[WinApi with empty peoject example](CW/lesson_1/winApi32EmptyDemo "CW\lesson_1\winApi32EmptyDemo")   

[WinApi with basic template example](CW/lesson_1/winDeskAppDemo "CW\lesson_1\winDeskAppDemo")   

---

## Unicode vs ANSI
***ANSI (American National Standarts Institute)***   
***ASCII (American Standart Code for Information Interchange)***

> Ansi -> char array  
char -> 1 byte  
pow(2,8) = 256  

> Unicode  -> wide char array  
wchar_t -> 2 byte  
pow(2,16) = 65536   

```#define _UNICODE``` - добавляет обобщенный тип ```TCHAR```

```TCHAR array[15] = _TEXT("asdasd");```
```TCHAR array[15] = (L"asdasd");``` - макрос преобразует строку в юникод

### Transcodding
- ANSI -> Unicode
    - MultyByteToWideChar 
    - ```mbstowcs(...)```
- Unicode -> ANSI
    - WideByteCharToMultyByte
    - ```wcstombs(...)```

## Notations
 - Pascal -> ```private bool BookTitle (){}```
 - Camel -> ```public strin bookTitle(){}```
 - Hungary ->  ```protected int iBookTitle(){}```


---

</p></details>


<details><summary> 2. WinAPI. Input. Timer.  </summary><p>

---

[WinApi input events example](CW/lesson_2/winApi_input_events "CW\lesson_2\winApi_input_events")   

[WinForms timer example](CW/lesson_2/winForms_timer "CW\lesson_2\winForms_timer")   

---

</p></details>



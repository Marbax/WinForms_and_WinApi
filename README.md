# WinForms_and_WinApi
 WinForms and WinApi lessons repository

<details><summary> 1. WinAPI </summary><p>

---

[WinApi with empty peoject example](CW/lesson_01/winApi32EmptyDemo "CW\lesson_01\winApi32EmptyDemo")   

[WinApi with basic template example](CW/lesson_01/winDeskAppDemo "CW\lesson_01\winDeskAppDemo")   

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

[WinApi input events example](CW/lesson_02/winApi_input_events "CW\lesson_02\winApi_input_events")   

[WinForms timer example](CW/lesson_02/winForms_timer "CW\lesson_02\winForms_timer")   

---

</p></details>


<details><summary> 3. WinForms. Controls.  </summary><p>

---

[WinForms trackBar example](CW/lesson_03/color_mixer "CW\lesson_02\color_mixer")   

[WinForms radioBtn and textBox example](CW/lesson_03/converter_of_temp "CW\lesson_02\converter_of_temperature")   

[WinForms textBox example](CW/lesson_03/statistic_calc "CW\lesson_02\statistic_calc")   

[WinForms work with folders and images example](CW/lesson_03/image_viewer "CW\lesson_02\image_viewer")   

[WinForms time span example](CW/lesson_03/timer_v2 "CW\lesson_02\timer_v2")   

[WinForms time span calc](HW/HW_03/time_span_calc "HW\HW_03\time_span_calc ")   

[WinForms progressBar and text fromatter](HW/HW_03/profile_feeller "HW\HW_03\profile_feeller ")   

---

</p></details>



<details><summary> 4. Additional Windows(dialogs).  </summary><p>

---

[WinForms work with folders and images example](CW/lesson_03/image_viewer "CW\lesson_03\image_viewer")   

## Entity Framework
- Создать БД
- Поставить обновление по новизне
- Скопировать путь подключения к БД (*.mdf -> Properties -> Connection String) и добавить в конфирацию приложения
- Установить в проект **EntityFramework** (Solution Explorer -> Manage NuGet Packages)
- Подключить (в DataManager) **EntityFramework** - ```using System.Data.Entity;```
- Tools -> NuGet Package Manager -> Package Manager Console
    -  Прописать в консоли PM ```enable-migrations```
    -  Прописать в консоли PM ```add-migration "MigrationName"```
    -  Прописать в консоли PM ```update-database"```


[WinForms and EntityFramework example](CW/lesson_04/my_web_browser "CW\lesson_04\my_web_browser")   

[WinForms customm event , link, return from non modal form example](HW/HW_04/useless_file_editor "HW\HW_04\useless_file_editor")   

---

> 1 HW по 5 уроку

</p></details>




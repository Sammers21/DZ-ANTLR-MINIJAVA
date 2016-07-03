Поряд действий таков:
1)Запустить gen.bat
2)Запустить make.bat
3)Запустить test.bat и убедиться в правильном результате работы программы


gen.bat - генерирует .cs файлы в папку scr
make.bat - компилирует компилятор для minijava(часть языка Java которую мне необходимо было реализовать)
test.bat : 
*Переносит все фалы содержащие код тестов с разрешением .minijava в папку res из папки testsuite.
*Запускает копмилятор Program.exe. 
*Компилирует каждый сгенерированный .cs файл теста.
*Создаёт папку TestResults c папкой CSharpTestFiles, где храняться резульат работы Program.exe, и папкой EXETestFiles, где храниться скомпилированные по одному файлы из CSharpTestFiles.
*Запускает по очереди каждый файл из папки EXETestFiles.
clear.bat - очищает папки res и scr

Примечание:
Скомпилированный компилятор Program.exe рабоет следующим образом: берет файлы с именами 

test1.minijava
test2.minijava
test3.minijava
test4.minijava
test5.minijava
test6.minijava
test7.minijava

и генерирует .cs файлы

test1.cs
test2.cs
test3.cs
test4.cs
test5.cs
test6.cs
test7.cs

с кодом соответсвующим кодом на языке C#.
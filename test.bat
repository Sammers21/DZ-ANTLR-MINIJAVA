copy testsuite\*.minijava res
cd res

Program.exe

C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:exe test1.cs

C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:exe test2.cs

C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:exe test3.cs

C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:exe test4.cs

C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:exe test5.cs

C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:exe test6.cs

C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /t:exe test7.cs




mkdir TestResults
cd TestResults

mkdir CSharpTestFiles
mkdir EXETestFiles

cd..

move test1.cs TestResults
move test2.cs TestResults
move test3.cs TestResults
move test4.cs TestResults
move test5.cs TestResults
move test6.cs TestResults
move test7.cs TestResults
move test1.exe TestResults
move test2.exe TestResults
move test3.exe TestResults
move test4.exe TestResults
move test5.exe TestResults
move test6.exe TestResults
move test7.exe TestResults

cd TestResults
move *.cs CSharpTestFiles
move *.exe EXETestFiles

cd ..

del /Q /F *.cs

cd TestResults
cd EXETestFiles

test1.exe

test2.exe

test3.exe

test4.exe

test5.exe

test6.exe

test7.exe


pause

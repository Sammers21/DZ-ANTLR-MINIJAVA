copy *.cs res
copy scr\*.cs res
copy Antlr4.Runtime.dll res
cd res
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe /r:Antlr4.Runtime.dll *.cs
del /Q /F *.cs
pause

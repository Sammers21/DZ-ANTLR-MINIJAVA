����� �������� �����:
1)��������� gen.bat
2)��������� make.bat
3)��������� test.bat � ��������� � ���������� ���������� ������ ���������


gen.bat - ���������� .cs ����� � ����� scr
make.bat - ����������� ���������� ��� minijava(����� ����� Java ������� ��� ���������� ���� �����������)
test.bat : 
*��������� ��� ���� ���������� ��� ������ � ����������� .minijava � ����� res �� ����� testsuite.
*��������� ���������� Program.exe. 
*����������� ������ ��������������� .cs ���� �����.
*������ ����� TestResults c ������ CSharpTestFiles, ��� ��������� �������� ������ Program.exe, � ������ EXETestFiles, ��� ��������� ���������������� �� ������ ����� �� CSharpTestFiles.
*��������� �� ������� ������ ���� �� ����� EXETestFiles.
clear.bat - ������� ����� res � scr

����������:
���������������� ���������� Program.exe ������ ��������� �������: ����� ����� � ������� 

test1.minijava
test2.minijava
test3.minijava
test4.minijava
test5.minijava
test6.minijava
test7.minijava

� ���������� .cs �����

test1.cs
test2.cs
test3.cs
test4.cs
test5.cs
test6.cs
test7.cs

� ����� �������������� ����� �� ����� C#.

���� �������:
��������: ������������ ����� Java 
���������: "=,*" 
���������: Enum, functions, for *������ �� ���� ���������*, System.out.println() 
����: double 


��� 

class A { 
enum Language{ 
Python, Java, Csharp, Cplusplus, C, Swift, Javascript 
} 

public static double multiply(double num){ 
return num*2.0; 
} 

public static void main(String[] args) { 
System.out.println("I am young, i prefer: "); 
System.out.println(Language.Csharp); 
System.out.println("On the second course, i would use: "); 
System.out.println(Language.Java); 

// �������� ������� 
double[] quartiles = {0.0,0.25,0.5,0.75,1.0}; 

// �������������� ����� � Java, �������� ���� ������ ��������� ��������� ���������� � quartile 
for (double quartile: quartiles){ 
System.out.println(multiply(quartile)); 
} 
} 
} 
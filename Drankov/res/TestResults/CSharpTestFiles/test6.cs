using System;
class A {
enum Language{
Python,Java,Csharp,Cplusplus,C,Swift,Javascript
};
public static double multiply(double num){
return num*2.0;

}
public static void Main(string[] args){
Console.WriteLine("I am young, i prefer: ");
Console.WriteLine(Language.Csharp);
Console.WriteLine("On the second course, i would use: ");
Console.WriteLine(Language.Java);
double[] quartiles = {0.0,0.25,0.5,0.75,1.0};
foreach (double quartile in quartiles){
Console.WriteLine(multiply(quartile));

}

}
}
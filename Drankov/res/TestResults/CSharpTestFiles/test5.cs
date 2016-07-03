using System;
class A {
public static void Main(string[] args){
double x=1.0;
double y =2.0;
double z=x * y;
double[] values={1.2,2.4,3.6,4.8,6.0};
foreach (double X in values){
z=z*X;
Console.WriteLine(z);

}
Console.WriteLine("end");

}
}
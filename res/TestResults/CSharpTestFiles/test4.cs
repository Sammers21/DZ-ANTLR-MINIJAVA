using System;
class A {
public static void onemult(double numb,double pow){
numb=pow*numb;
Console.WriteLine("one mult is:");
Console.WriteLine(numb);

}
public static void twomult(double number,double POW){
number=POW*number;
number=POW*number;
Console.WriteLine("two mult is:");
Console.WriteLine(number);

}
public static void Main(string[] args){
double x=2.0;
double[] X={1.0,2.0,4.0,8.0,16.0,32.0,64.0,128.0,256.0};
foreach (double d in X){
onemult(x,d);
twomult(x,d);

}

}
}
using System;
class A {
enum Planets{
Mars,Mercury,Neptune,Pluto,Saturn,Uranus,Venus,Earth
};
public static void Main(string[] args){
Console.WriteLine("Today we live on the");
Console.WriteLine(Planets.Earth);
Console.WriteLine("But tomorrow we will live on");
Console.WriteLine(Planets.Mars);

}
}
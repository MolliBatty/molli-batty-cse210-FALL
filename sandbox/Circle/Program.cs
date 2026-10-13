using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle(); //myCircle is object

        myCircle._radius = 10;

        double area = myCircle.GetArea();
        
        Console.WriteLine(area);

    }
}
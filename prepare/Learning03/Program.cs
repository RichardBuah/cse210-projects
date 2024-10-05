using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");
        Fraction frac1 = new Fraction();
        /* Test for getters and setters
        int topnumber = frac1.GetTopValue();
        int botomnumber = frac1.GetBottomValue();
        Console.WriteLine($"{topnumber}, {botomnumber}");
        frac1.SetTopValue(2);
        frac1.SetBottomValue(4);
        topnumber = frac1.GetTopValue();
        botomnumber = frac1.GetBottomValue();
        Console.WriteLine($"{topnumber}, {botomnumber}"); 
        */
        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        Fraction frac2 = new Fraction(5);
        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        Fraction frac3 = new Fraction(3,4);
        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());
        
        Fraction frac4 = new Fraction(1,3);
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());
    }
}
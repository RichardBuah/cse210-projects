using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");
        // Test 1
        Console.WriteLine("Test One");
        MathAssignment math1 = new MathAssignment("Roberto Rodriguez","Fractions","Section 7.3", "Problems 8-19");
        MathAssignment math2 = new MathAssignment();
        Console.WriteLine(math2.Getsummary());
        Console.WriteLine(math2.GetHomeworkList());
        Console.WriteLine(math1.Getsummary());
        Console.WriteLine(math1.GetHomeworkList());

        // Test 2
        Console.WriteLine("\nTest Two");
        WritingAssignment write1 = new WritingAssignment();
        WritingAssignment write2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(write1.Getsummary());
        Console.WriteLine(write1.GetWritingInformation());
        Console.WriteLine(write2.Getsummary());
        Console.WriteLine(write2.GetWritingInformation());
    }
}
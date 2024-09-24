using System;
using System.Collections.Generic;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        List<int> data = new List<int>();
        int addData = 1;
        int largestNumber = 0;        

        while (addData != 0){
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.WriteLine("Enter Number: ");
            string numb = Console.ReadLine();
            addData = int.Parse(numb);

            if (addData != 0){
                data.Add(addData);
                Console.WriteLine("Data added.");
            }

            }
        
        // Calculating for total data
        float totalNum = 0;
        foreach (int num in data){
            totalNum += num;
        }
        Console.WriteLine($"The total is {totalNum}");
        
        // Calculating for average 
        float averageData = totalNum/(data.Count);
        Console.WriteLine($"The average is {averageData}");

        // looking for the largest number
        
        foreach (int num in data){
            if (num > largestNumber){
                largestNumber = num;
            }            

        }
        Console.WriteLine($"The largest number is {largestNumber}");
    }
}
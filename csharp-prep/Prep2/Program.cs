using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade in percentage?");
        string studentGrade = Console.ReadLine();
        int gradeNumber = int.Parse(studentGrade);
        string letterGrade = "";

        if (gradeNumber >= 90) {
            letterGrade = "A";
        }
        else if (gradeNumber >=80 && gradeNumber<90) {
            letterGrade = "B";
            }
        else if (gradeNumber >=70 && gradeNumber <80){
            letterGrade = "C";
        }
        else if (gradeNumber >= 60 && gradeNumber <70){
            letterGrade = "D";
        }
        else {
            letterGrade = "F";
        }

        int lastDigit = gradeNumber % 10;
        if (gradeNumber >= 60 && gradeNumber <= 92 && lastDigit >= 7){
            Console.WriteLine($"You have grade {letterGrade}+");
        }
        else if (gradeNumber >= 60 && gradeNumber <= 92 && lastDigit < 3){
            Console.WriteLine($"You have grade {letterGrade}-");
        }
        else{
            Console.WriteLine($"You have grade {letterGrade}");
        }

        if (gradeNumber >= 70){
            Console.Write("Congratulations! You passed your exam.");
        }
        else {
            Console.Write("You did your best. Try harder next time.");
        }
    }
}
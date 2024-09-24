using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int SquareNum = SquareNumber(userNum);
        DisplayResult(userName, SquareNum);
    }

    static void DisplayWelcome(){
        Console.Write("Welcome to richard's the program!");
    }

    static string PromptUserName(){
        Console.Write("Enter your name. ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber(){
        Console.Write("Enter your any favorite number of choice. ");
        string userNum = Console.ReadLine();
        int number = int.Parse(userNum);
        return number;
    }
    static int SquareNumber(int number){
        int squareNum = number*number;
        return squareNum;
    }

    static void DisplayResult(string userName, int squareNum){
        Console.Write($"Brother {userName}, the square of your number is {squareNum}.");
    }


}
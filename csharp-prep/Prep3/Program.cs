using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        // Console.Write("What is the magic number?");
        // string magicNumber = Console.ReadLine();
        // int mgNumber = int.Parse(magicNumber);

        Random randomGen = new Random();
        int mgNumber = randomGen.Next(1, 100);

        string play = "yes";
        int counter = 1;

        while (play == "yes") {
            Console.Write("What is your guess?");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);

            if (guessNumber == mgNumber){
                Console.WriteLine($"Your guessed it right with {counter} guesses!");
                play = "No";
            }
            else if (guessNumber < mgNumber){
                Console.WriteLine("Your guess was lower");
                Console.WriteLine("Keep on trying. Enter a new number.");
                counter += 1;
            }
            else{
                Console.WriteLine("Your guess was higher");
                Console.WriteLine("Keep on trying. Enter a new number.");
                counter += 1;
            }
            if (play != "yes"){
                Console.WriteLine("Do you want to play again? Type 'yes' or 'no'");
                play = Console.ReadLine();
                mgNumber = randomGen.Next(1, 100);
                counter = 0;
            }           
        }        
    }
}
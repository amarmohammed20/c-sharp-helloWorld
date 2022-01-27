using System;

// Namespace which is the main area for all the code inc the class to be stored
namespace NumberGuesser
{
    // In OOP we working in classes and this is the main class
    public class Program
    {
        //Entry point for the application, meathod 
        //Static is a function that can contain code but we use void as it returns nothing
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string author = "Amar Mohammed";

            //Change colour of text for Title/Header
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, author);

            //Reset the text colour
            Console.ResetColor();

            //Ask users name
            Console.WriteLine("What is your name?");

            //Place the username into a string variable
            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game of number guessing....", name);

            //Set correct number 
            int correctNumber = 7;

            //Number that is guessed
            int guessedNumber = 0;

            Console.WriteLine("Guess a number between 1 and 10 ....");

            while(guessedNumber != correctNumber)
            {
                string numberAttempted = Console.ReadLine();
                guessedNumber = int.Parse(numberAttempted);

                if(guessedNumber != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Hard luck you guessed {0} and that is not the right answer, try again .....", numberAttempted);

                    Console.ResetColor();
                }

            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Well done you guessed the right number of {0} dont get excited this is only .net it wont be around in a few days .....", correctNumber);

            Console.ResetColor();
        }
    }
}

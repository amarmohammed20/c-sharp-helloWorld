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
            //Below is a function that provides app information
            AppInfo();

            //Function to gather user information
            UserGreet();

            //Code below wrapped in a while loop so the game keeps going after the number is guessed right
            while (true)
            {

                //Create a random number as the correct number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Number that is guessed
                int guessedNumber = 0;

                Console.WriteLine("Guess a number between 1 and 10 ....");



                while (guessedNumber != correctNumber)
                {
                    string numberAttempted = Console.ReadLine();

                    //Make sure the number inputted is a number
                    if (!int.TryParse(numberAttempted, out guessedNumber))
                    {
                        ScreenTextPrint(ConsoleColor.Red, "Please type a number, this is a number guessing game silly.....");
                        //Keep the app running to get another guess
                        continue;
                    }

                    guessedNumber = int.Parse(numberAttempted);

                    if (guessedNumber != correctNumber)
                    {
                        ScreenTextPrint(ConsoleColor.Red, "Hard luck your guess was not the right answer, try again .....");
                    }

                }


                //The success message
                ScreenTextPrint(ConsoleColor.Yellow, "Well done you guessed the right number, dont get excited this is only .net it wont be around in a few days .....");

                //Ask the user if they would like to play again
                Console.WriteLine("Play again? [Y or N]");

                //User states if they would like to play again
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        static void AppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string author = "Amar Mohammed";

            //Change colour of text for Title/Header
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, author);

            //Reset the text colour
            Console.ResetColor();
        }
        static void UserGreet()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Place the username into a string variable
            string name = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game of number guessing....", name);
        }
        //A reuseable function that takes in a color and message and prints to the screen
        static void ScreenTextPrint(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}

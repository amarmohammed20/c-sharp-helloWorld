using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a comment, same as JavaScript

            Console.Title = "Story Time";
            Console.WindowHeight = 40;

            Console.WriteLine("A man called .....");
            Console.ReadLine();

            Console.WriteLine("..... Tried to learn the coding lanuage .....");
            Console.ReadLine();

            Console.WriteLine("..... He found that his learning was very slow, so he went to work as a .....");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("..... To late his wife left him for a real coder ;) .....");
            Console.ReadLine();
        }
    }
}

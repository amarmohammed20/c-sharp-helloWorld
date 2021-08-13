using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {
            //This is a comment, same as JavaScript

            Console.Title = "Story Time";
            Console.WindowHeight = 40;

            Console.WriteLine("A man called .....");
            string name = Console.ReadLine();

            Console.WriteLine(name + " tried to learn the coding lanuage .....");
            string lanuage = Console.ReadLine();

            Console.WriteLine(name + " found " + lanuage + " very hard, so he went to work as a .....");
            string job = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("His wife wished for higher things than a " + job + ". So she left his sorry ass!");

            Console.Write("Set " + name + " age for him, this could be his last chance: ");
            int age = Convert.ToInt32( Console.ReadLine() );

            int newAge = age + 5;

            Console.WriteLine(name + " told his wife that " + age + " is still young enough for another chance. In 5 years time he will be " + newAge);
            Maths();
        }
        public static void Maths() => Console.WriteLine("Maths Time");
    }
}

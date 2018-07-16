using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Please enter your name.");
			Console.Write("Type your first name: ");
			string myFirstName = Console.ReadLine();

			Console.Write("Type your last name: ");
			string myLastName = Console.ReadLine();

			Console.Write("Hello" + " " + myFirstName + " " + myLastName + "!");
			Console.ReadLine();
        }
    }
}

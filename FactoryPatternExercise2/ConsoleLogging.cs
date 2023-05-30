using System;
namespace FactoryPatternExercise2
{
	public class ConsoleLogging
	{
		public static void Greeting()
		{
            Console.WriteLine("Hello, what type of database would you like to use: List, SQL, or Mongo?");
        }

		public static void DatabaseAccessText()
		{
			Console.WriteLine("Accessing Database...");
			Thread.Sleep(1000);
		}
	}
}


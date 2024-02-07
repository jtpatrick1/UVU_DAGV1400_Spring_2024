using System;
					
public class Program
{
	string userInput;
	string[] foodItems = {"one", "two", "three"};
	public void Main()
	{
		for (var i = 0; i < 3; i++)
		{
			Console.Write("What is one of your favorite foods?: ");
			userInput = Console.ReadLine();
			foodItems[i] = userInput;
		}
		
		for (var x = 0; x < 3; x++)
		{
			Console.WriteLine("I love " + foodItems[x] + ".");
		}
	}
}
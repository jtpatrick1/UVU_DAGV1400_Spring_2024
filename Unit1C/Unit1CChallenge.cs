using System;
					
public class Program
{
	
	public static void Main()
	{
		Random r; 
		r = new Random();
		int genRand = r.Next(1,11);
		Console.WriteLine(genRand);
		int numOfTries = 0;
		
		for (var i = 0; i < 5; i++)
		{
			string UserNumber = Console.ReadLine();
			numOfTries++;
			
			if (int.Parse(UserNumber) < genRand)
			{
				Console.WriteLine("You guessed a little low");
			}
			else if (int.Parse(UserNumber) > genRand)
			{
				Console.WriteLine("You guessed a little high");
			}
			else
			{
				Console.WriteLine("You got it!");
				Console.WriteLine("It took you " + numOfTries + " tries");
				break;
			}
		}
	}
}

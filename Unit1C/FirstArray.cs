using System;
					
public class Program
{
	public int UserNumber;
	public void Main()
	{
		Console.WriteLine("Pick a number between 1 and 4");
		UserNumber = int.Parse(Console.ReadLine());
		String[] games = {"Halo", "Starcraft", "War Thunder", "Empires of the Undergrowth"};
		Console.WriteLine(games[UserNumber - 1]);
		Console.WriteLine(games.Length);
	}
}
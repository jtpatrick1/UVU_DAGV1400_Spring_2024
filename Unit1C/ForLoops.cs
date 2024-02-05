using System;
					
public class Program
{
	public void Main()
	{
		string[] fleet = {"frigate", "cruiser", "cruiser", "carrier"};
		for (var i = 0; i < (fleet.Length); i++)
		{
			if (fleet[i] == "frigate")
			{
				fleet[i] = "cruiser";
			}
			else if (fleet[i] == "cruiser")
			
			{
				fleet[i] = "battleship";
			}
		}
		foreach (var ship in fleet)
		{
			Console.WriteLine(ship);
		}
	}
}
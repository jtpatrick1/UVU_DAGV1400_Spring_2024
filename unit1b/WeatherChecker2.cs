using System;

public class WeatherChecker
{
	public string UserWeather;
	public int Temperature;
	public void Main()
	{
		Console.WriteLine("What is the temperature?");
		UserWeather = Console.ReadLine();
		Temperature = int.Parse(UserWeather);
		if (Temperature > 20)
		{
			Console.WriteLine("You should put on some sunscreen and have fun at the pool.");
		} 
		else if (Temperature > 10)
		{
			Console.WriteLine("You should wear a light jacket today.");
		}
		else if (Temperature > 0)
		{
			Console.WriteLine("It's time to pull out the heavy coats.");
		}
		
		
		else if (Temperature > -10)
		{
			Console.WriteLine("Stay home, make a cup of hot chocolate and get the heavy blankets out.");
		}
	}
}

using System;
					
public class Program
{
	public int UserNumber;
	public void Main()
	{
		Console.WriteLine("Enter a number");
		UserNumber = int.Parse(Console.ReadLine());
		
		var numberArray = new int[UserNumber];
		//Console.WriteLine(numberArray.Length);
		
		
		for (var i = 0; i < UserNumber; i++)
		{
			for (var x = 0; x < (i+1); x++)
			{
				numberArray[x] = i;
				Console.Write(numberArray[x] + 1);
			}
			Console.WriteLine("");
		}
		
	}
}
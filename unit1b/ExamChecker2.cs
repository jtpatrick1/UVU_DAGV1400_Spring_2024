using System;
					
public class ExamChecker
{
	public SubjectChoice Grades;
	
	public void Main()
	{
		Grades = new SubjectChoice();
		Grades.PickAClass();
	}
}

public class SubjectChoice
{
		
	public string UserClass;
	public string UserScore;
	public int Score;

	
	public void PickAClass()
	{
		Console.WriteLine("What class is your score in?");
		UserClass = Console.ReadLine();
		
		Console.WriteLine("What is you're score?");
		UserScore = Console.ReadLine();
		Score = int.Parse(UserScore);
		
		switch (UserClass)
		{
			case "math":
				if (Score >= 80)
				{
					Console.WriteLine("You're doing good, keep up the good work!");
				}
				else
				{
					Console.WriteLine("Try studying some more mathematical concepts, or possibly join a study group");
				}
				break;
			
			case "english":
				if (Score >= 80)
				{
					Console.WriteLine("Keep up the good work!");
				}
				else
				{
					Console.WriteLine("You should have more people peer review your essays.");
				}
				break;
			case "science":
				if (Score >= 80)
				{
					Console.WriteLine("Keep up the good work!");
				}
				else
				{
					Console.WriteLine("You should watch more Bill Nye vidoes.");
				}
				break;
		}
	}
}

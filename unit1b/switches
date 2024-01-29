using System;

public class Program
{
	public Action action;
	
	public void Main()
	{
		action = new Action();
		action.CheckAction();
	}
}

public class Action
{
	public enum ActionSequence
	{
		shooting,
		punching,
		sliding,
		dead
	}
	
	public ActionSequence action = ActionSequence.punching;
	
	public void CheckAction()
	{
		switch(action)
		{
			case ActionSequence.dead:
				Console.WriteLine("You're dead.");
				break;
				
			case ActionSequence.punching:
				Console.WriteLine("You hit them!");
				break;
			
			case ActionSequence.shooting:
				Console.WriteLine("Reload!");
				break;
				
			case ActionSequence.sliding:
				Console.WriteLine("You're in cover!");
				break;
		}
	}
}

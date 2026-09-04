using StrategyPattern.Interfaces.SwimBehavior;

public class CanSwim : SwimBehavior
{
    public void Swim()
    {
        Console.WriteLine("I’m swimming");
    }
}
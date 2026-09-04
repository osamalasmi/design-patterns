using StrategyPattern.Interfaces.QuackBehavior;

public class Squeak : QuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak");
    }
}
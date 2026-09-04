namespace StrategyPattern.Interfaces.SwimBehavior;
public class Sink : SwimBehavior
{
    public void Swim()
    {
        Console.WriteLine("Sinking to the bottom...");
    }
}
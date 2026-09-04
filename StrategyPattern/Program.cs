using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.SwimBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();


            Console.WriteLine("MallardDuck:");
            mallardDuck.SetQuackBehavior(new RegularQuack());
            mallardDuck.PerformQuack();

            mallardDuck.SetFlyBehavior(new FlyWithWings());
            mallardDuck.PerformFly();

            mallardDuck.SetSwimBehavior(new CanSwim());
            mallardDuck.PerformSwim();

            Console.WriteLine("RedheadDuck:");
            redheadDuck.SetQuackBehavior(new RegularQuack());
            redheadDuck.PerformQuack();

            redheadDuck.SetSwimBehavior(new CanSwim());
            redheadDuck.PerformSwim();

            Console.WriteLine("DecoyDuck:");
            decoyDuck.SetQuackBehavior(new MuteQuack());
            decoyDuck.PerformQuack();

            decoyDuck.SetFlyBehavior(new FlyNoWay());
            decoyDuck.PerformFly();

            decoyDuck.SetSwimBehavior(new CanSwim());
            decoyDuck.PerformSwim();

            Console.WriteLine("RubberDuck:");
            rubberDuck.SetQuackBehavior(new Squeak());
            rubberDuck.PerformQuack();

            rubberDuck.SetFlyBehavior(new FlyNoWay());
            rubberDuck.PerformFly();

            rubberDuck.SetSwimBehavior(new CanSwim());
            rubberDuck.PerformSwim();

            Console.WriteLine("RobotDuck:");
            robotDuck.SetSwimBehavior(new Sink());
            robotDuck.PerformSwim();

        }
    }
}
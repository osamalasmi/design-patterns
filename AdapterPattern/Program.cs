using AdapterPattern.Geese;
using AdapterPattern.Interfaces;
using AdapterPattern.Turkeys;
using System;
using System.Threading.Tasks.Dataflow;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Let's make a duck, turkey and a goose
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            CanadaGoose canadaGoose = new CanadaGoose();
            // Let's wrap the turkey in an adapter to make it look like a Duck
            Duck turkeyAdapter = new TurkeyAdapter(turkey);
            Duck gooseAdapter = new GooseAdapter(canadaGoose);

            // Testing the turkey.
            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            // Testing the goose.
            Console.WriteLine("The Goose says...");
            canadaGoose.Honk();
            canadaGoose.Fly();

            // Testing the duck with the testDuck() method, which expects a Duck object
            Console.WriteLine("The Duck says...");
            TestDuck(duck);

            // Now let's test the turkey using the testDuck() method
            // (which still expects a Duck object)
            Console.WriteLine("The TurkeyAdapter says...");
            TestDuck(turkeyAdapter);

            // goose test as a duck
            Console.WriteLine("The GooseAdapter says...");
            TestDuck(gooseAdapter);
        }

        // Method to get a duck to call its Quack() and Fly() methods
        static void TestDuck(Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
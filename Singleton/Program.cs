namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler1 = ChocolateBoiler.GetInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();
            Console.WriteLine($"Same instance: {ReferenceEquals(boiler1, boiler2)}");

            boiler1.fill();
            boiler1.boil();
            Console.WriteLine($"Via boiler2: empty = {boiler2.IsEmpty}, boiled = {boiler2.IsBoiled}");
            boiler2.drain();
            Console.WriteLine($"After drain: empty = {boiler1.IsEmpty}");

            // Many threads asking for the instance at the same time must all get the same object
            var instances = new ChocolateBoiler[100];
            Parallel.For(0, instances.Length, i => instances[i] = ChocolateBoiler.GetInstance());
            Console.WriteLine($"Unique instances over 100 threads: {instances.Distinct().Count()}");
        }
    }
}

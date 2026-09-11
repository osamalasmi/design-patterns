namespace NoDesignPatternsBetaalmethode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BetaalProcessor processor = new BetaalProcessor();

            processor.SetBetalen(new Creditcard());
            processor.Betalen(10, "1234567890123456");

        }
    }
}
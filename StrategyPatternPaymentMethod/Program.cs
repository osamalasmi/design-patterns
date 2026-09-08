namespace NoDesignPatternsBetaalmethode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BetaalProcessor processor = new BetaalProcessor();

            processor.VerwerkBetaling(
                BetaalMethode.Creditcard,
                100.00m,
                "1234567812345678");

            processor.VerwerkBetaling(
                BetaalMethode.PayPal,
                50.00m,
                "jaap@gmail.com]");

            processor.VerwerkBetaling(
                BetaalMethode.Crypto,
                0.005m,
                "1A2b3C4d5E6F");

            // Foutieve betaling
            processor.VerwerkBetaling(
                BetaalMethode.Creditcard,
                20.00m,
                "1234");
        }
    }
}
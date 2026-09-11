using System.Text.RegularExpressions;
using StrategyPatternPaymentMethod.Interfaces.IBetaalMethode;

public class Crypto : IBetaalMethode
{

    public void VoerBetalingUit(decimal bedrag, string kaartGegevens)
    {
        if (kaartGegevens.Length < 10)
            throw new ArgumentException(
                "Ongeldig wallet-adres. Moet minstens 10 tekens lang zijn.");

        Console.WriteLine(
            $"Betaling van {bedrag:C} uitgevoerd met cryptocurrency-wallet: {kaartGegevens}");
    }
}
using System.Text.RegularExpressions;
using StrategyPatternPaymentMethod.Interfaces.IBetaalMethode;

public class PayPal : IBetaalMethode
{

    public void VoerBetalingUit(decimal bedrag, string kaartGegevens)
    {
        if (!Regex.IsMatch(kaartGegevens, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            throw new ArgumentException("Ongeldig e-mailadres.");

        Console.WriteLine(
            $"Betaling van {bedrag:C} uitgevoerd via PayPal-account: {kaartGegevens}");
    }
}
using StrategyPatternPaymentMethod.Interfaces.IBetaalMethode;

public class Creditcard : IBetaalMethode
{

    public void VoerBetalingUit(decimal bedrag, string kaartGegevens)
    {
        if (kaartGegevens.Length != 16)
            throw new ArgumentException(
                "Ongeldig kaart gegevens. Moet 16 cijfers bevatten.");

        Console.WriteLine(
            $"Betaling van {bedrag:C} uitgevoerd met creditcard: {kaartGegevens}");
    }
}
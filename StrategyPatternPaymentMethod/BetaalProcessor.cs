using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using StrategyPatternPaymentMethod.Interfaces.IBetaalMethode;

namespace NoDesignPatternsBetaalmethode
{
    enum BetaalMethode
    {
        Creditcard,
        PayPal,
        Crypto
    }
    internal class BetaalProcessor
    {
        protected IBetaalMethode iBetaalMethode;

        public void Betalen(decimal bedrag, string kaartGegevens)
        {
            iBetaalMethode.VoerBetalingUit(bedrag, kaartGegevens);
        }

        public void SetBetalen(IBetaalMethode ibm)
        {
            iBetaalMethode = ibm;
        }
        public void VerwerkBetaling(BetaalMethode betaalMethode, decimal bedrag, string betaalGegevens)
        {
            try
            {
                switch (betaalMethode)
                {
                    case BetaalMethode.Creditcard:
                        BetaalMetCreditcard(bedrag, betaalGegevens);
                        break;

                    case BetaalMethode.PayPal:
                        BetaalMetPayPal(bedrag, betaalGegevens);
                        break;

                    case BetaalMethode.Crypto:
                        BetaalMetCrypto(bedrag, betaalGegevens);
                        break;

                    default:
                        Console.WriteLine("Onbekende betaalmethode.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fout bij betaling: {ex.Message}");
            }
        }

        private void BetaalMetCreditcard(decimal bedrag, string kaartNummer)
        {
            if (kaartNummer.Length != 16)
                throw new ArgumentException(
                    "Ongeldig kaartnummer. Moet 16 cijfers bevatten.");

            Console.WriteLine(
                $"Betaling van {bedrag:C} uitgevoerd met creditcard: {kaartNummer}");
        }

        private void BetaalMetPayPal(decimal bedrag, string email)
        {
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Ongeldig e-mailadres.");

            Console.WriteLine(
                $"Betaling van {bedrag:C} uitgevoerd via PayPal-account: {email}");
        }

        private void BetaalMetCrypto(decimal bedrag, string walletAdres)
        {
            if (walletAdres.Length < 10)
                throw new ArgumentException(
                    "Ongeldig wallet-adres. Moet minstens 10 tekens lang zijn.");

            Console.WriteLine(
                $"Betaling van {bedrag:C} uitgevoerd met cryptocurrency-wallet: {walletAdres}");
        }
    }
}

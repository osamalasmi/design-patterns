using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using StrategyPatternPaymentMethod.Interfaces.IBetaalMethode;

namespace NoDesignPatternsBetaalmethode
{
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
    }
}

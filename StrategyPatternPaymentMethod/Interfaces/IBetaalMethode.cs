using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternPaymentMethod.Interfaces.IBetaalMethode{
    internal interface IBetaalMethode
    {
        public void VoerBetalingUit(decimal bedrag, string kaartGegevens);
    }
}
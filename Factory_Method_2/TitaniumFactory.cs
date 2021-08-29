using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_2
{
    public class TitaniumFactory: CardFactory
    {
        private int creditLimit;
        private int annualCharge;

        public TitaniumFactory(int CreditLimit, int AnnualCharge)
        {
            this.creditLimit = CreditLimit;
            this.annualCharge = AnnualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(creditLimit, annualCharge);
        }
    }

    
}

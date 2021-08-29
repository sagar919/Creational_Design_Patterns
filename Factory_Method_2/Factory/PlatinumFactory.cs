using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_2
{
    public class PlatinumFactory: CardFactory
    {
        public int creditLimit;
        public int annualCharge;

        public PlatinumFactory(int AnnualCharge, int CreditLimit)
        {
            this.creditLimit = CreditLimit;
            this.annualCharge = AnnualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(creditLimit, annualCharge);
        }
    }
}

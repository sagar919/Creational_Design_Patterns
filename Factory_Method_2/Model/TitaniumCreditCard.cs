using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_2
{
    public class TitaniumCreditCard : CreditCard
    {
        private readonly string cardtype;
        private int annualCharge;
        private int creditLimit;

        public TitaniumCreditCard(int AnnualCharge, int CreditLimit)
        {
            this.cardtype = "Titanium";
            this.annualCharge = AnnualCharge;
            this.creditLimit = CreditLimit;
        }

        public override string CardType
        {
            get { return cardtype; }
        }

        public override int AnnualCharge
        {
            get { return annualCharge; }
            set { annualCharge = value; }
        }

        public override int CreditLimit
        {
            get { return creditLimit; }
            set { creditLimit = value; }
        }
    }
}

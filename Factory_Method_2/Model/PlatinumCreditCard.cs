using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_2
{
    public class PlatinumCreditCard : CreditCard
    {
        private readonly string cardtype;
        private int annualCharge;
        private int creditLimit;

        public PlatinumCreditCard(int AnnualCharge, int CreditLimit)
        {
            this.cardtype = "Platinum";
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_2
{
    public class MoneyBackFactory : CardFactory
    {
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackFactory(int CreditLimit, int AnnualCharge)
        {
            _creditLimit = CreditLimit;
            _annualCharge = AnnualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(_creditLimit, _annualCharge);
        }
        
    }
}

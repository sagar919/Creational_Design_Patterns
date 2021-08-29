using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method_2
{
    public abstract class CreditCard
    {
        public abstract string CardType { get;  }

        public abstract int AnnualCharge { get; set; }

        public abstract int CreditLimit { get; set; }
    }
}

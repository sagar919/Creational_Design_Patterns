using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1
{
    public class Tesla_Factory : IAutoFactory
    {
        public IAuto make()
        {
            return new Tesla();
        }
    }
}

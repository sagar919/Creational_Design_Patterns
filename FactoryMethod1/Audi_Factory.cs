using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1
{
    public class Audi_Factory: IAutoFactory
    {
        public IAuto make()
        {
            return new Audi();
        }

        
    }
}

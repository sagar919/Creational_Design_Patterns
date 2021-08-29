using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1
{
    public interface IAutoFactory
    {
        public IAuto make();
    }
}

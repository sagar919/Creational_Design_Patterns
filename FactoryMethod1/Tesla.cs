using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1
{
    class Tesla : IAuto
    {
        public void start()
        {
            Console.WriteLine("The car is starting");
        }

        public void stop()
        {
            Console.WriteLine("The Car is stopping");
        }

        public void getName()
        {
            Console.WriteLine("The Car is Tesla");
        }
    }
}

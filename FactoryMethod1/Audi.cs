using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod1
{
    public class Audi : IAuto
    {
        
        public void start()
        {
            Console.WriteLine("The Car is Starting");
        }

        public void stop()
        {
            Console.WriteLine("The Car has Stopped");
        }

        public void getName()
        {
            Console.WriteLine("The Car name is Audi");
        }
    }
}

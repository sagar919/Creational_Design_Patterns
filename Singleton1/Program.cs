using System;

namespace Singleton1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton teacher = Singleton.GetInstance;
            teacher.printDetails("this is Teacher");

            Singleton student = Singleton.GetInstance;
            student.printDetails("this is Student");

        }

        public sealed class Singleton
        {
            private static Singleton instance = null;
            public static Singleton GetInstance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }

            private Singleton()
            {
            }

            public void printDetails(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}


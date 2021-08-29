using System;

namespace Factory_Method_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.WriteLine("Enter the card you want to look");
            string card = Console.ReadLine();

            switch (card)
            {
                case "moneyback":
                    factory = new MoneyBackFactory(5000, 100);
                    break;

                case "titanium":
                    factory = new TitaniumFactory(6000, 200);
                    break;

                case "platinum":
                    factory = new TitaniumFactory(7000, 300);
                    break;
                default:
                    break;
            }

            CreditCard creditCard = factory.GetCreditCard();
            Console.WriteLine("Your Card Details are below");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}", creditCard.CardType, creditCard.CreditLimit, creditCard.AnnualCharge);
            Console.ReadKey();



        }
    }
}

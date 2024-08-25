namespace FactoryPattern
{

    public abstract class Creditcard
    {
        public abstract string GetCardType();
        public abstract int GetCreditLimit();
        public abstract int GetAnnualCashback();
    }

    public class Platinum : Creditcard
    {
        public override int GetAnnualCashback()
        {
            return 500;
        }

        public override string GetCardType()
        {
            return "platinum";
        }

        public override int GetCreditLimit()
        {
            return 1000;
        }
    }
    public class Bronze : Creditcard
    {
        public override int GetAnnualCashback()
        {
            return 500;
        }

        public override string GetCardType()
        {
            return "bronze";
        }

        public override int GetCreditLimit()
        {
            return 1000;
        }
    }
    public class Titanium : Creditcard
    {
        public override int GetAnnualCashback()
        {
            return 500;
        }

        public override string GetCardType()
        {
            return "titanium";
        }

        public override int GetCreditLimit()
        {
            return 2000;
        }
    }


    public class CreditCardFactory
    {
        public static Creditcard GetCreditCard(string cardType)
        {
            Creditcard cardDetails = null;
            if (cardType == "Bronze")
            {
                cardDetails = new Bronze();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            return cardDetails;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Creditcard carddetails = CreditCardFactory.GetCreditCard("Platinum");
            

            Console.WriteLine(carddetails);
            if (carddetails != null)
            {
                Console.WriteLine("credicard cashback is " + carddetails.GetAnnualCashback());
                Console.WriteLine("credicard limit is " + carddetails.GetCreditLimit());
                Console.WriteLine("credicard type is " + carddetails.GetCardType());
            }
            else
            {
                Console.WriteLine("invalid cardtype");
            }

            Console.ReadKey();  

        }

    }
}
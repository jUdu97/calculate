using System;

namespace Calculation
{
    class Calculation
    {
        public static void InterestRate()
        {
            //class method that calculates Continous Compound Interest Rate
            double e = 2.71828;

            //ask user for initial payment amount
            Console.WriteLine("How much is your initial payment amount? ");
            string P = Console.ReadLine();
            int P1 = Convert.ToInt32(P);

            //ask user for rate as percentage
            Console.WriteLine("What is the rate of your payment (%)? ");
            string r1 = Console.ReadLine();
            decimal r2 = Convert.ToDecimal(r1);
            decimal r3 = ((decimal)r2) / 100;

            //ask user for length of payment
            Console.WriteLine("How long is your payment for (years)? ");
            string t1 = Console.ReadLine();
            int t2 = Convert.ToInt32(t1);

            //multiply rate by time
            double mul = ((double)r3) * t2;

            //raise e constant to power of rate * time
            double exponent = Math.Pow(e, mul);
            
            //multiply principal amount by e^(r * t)
            double cashAmount = P1 * exponent;
            Console.WriteLine("Total Amount: ");
            Console.WriteLine(cashAmount);

            return;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

}



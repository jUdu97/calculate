using System;

namespace Calculation
{
    class Calculation
    {
        public static void InterestRate()
        {
            ///class method that calculates Continuous Compound Interest Rate

            double e = 2.71828; //set e equal to constant value

            //ask user for initial payment amount
            Console.WriteLine("How much is your initial payment amount? ");
            string P = Console.ReadLine(); //reads initial payment input
            int P1 = Convert.ToInt32(P); //converts input to integer

            //ask user for rate as percentage
            Console.WriteLine("What is the rate of your payment (%)? ");
            string r1 = Console.ReadLine(); //reads % rate input
            decimal r2 = Convert.ToDecimal(r1); //converts % rate value to decimal
            decimal r3 = ((decimal)r2) / 100; //divide % rate by 100

            //ask user for length of payment
            Console.WriteLine("How long is your payment for (years)? ");
            string t1 = Console.ReadLine(); //reads length of payment input
            int t2 = Convert.ToInt32(t1); //converts input to integer

            //multiply rate by time
            double mul = ((double)r3) * t2;

            //raise e constant to power of rate * time
            double exponent = Math.Pow(e, mul);
            
            //multiply principal amount by e^(r * t)
            double cashAmount = P1 * exponent;
            Console.WriteLine("Total Continuous Amount: {0:C2}", cashAmount);

            return; //return none
        }
        public static void CompoundInterestRate()
        {
            ///class method that calculates Compound Interest Rate

            //ask user for initial payment amount
            Console.WriteLine("Enter initial payment: $");
            string initAmount = Console.ReadLine();
            int initAmount1 = Convert.ToInt32(initAmount);

            //ask user for rate as %
            Console.WriteLine("Enter rate (%): ");
            string rate= Console.ReadLine();
            decimal rate1 = Convert.ToDecimal(rate);
            decimal rate2 = ((decimal)rate1) / 100;

            //ask user for number of installments paid
            Console.WriteLine("Enter numbers of times paid: ");
            string n1 = Console.ReadLine();
            int n2 = Convert.ToInt32(n1);

            //ask user how long their payment plan is
            Console.WriteLine("Enter payment length in years: ");
            string timeYrs = Console.ReadLine();
            int timeYrs1 = Convert.ToInt32(timeYrs);

            //multiply number of payments by plan length 
            double multiplyNT = n2 * timeYrs1;

            //divide rate by number of payments
            double divRN = ((double)rate2) / n2;

            //add 1 to r/n
            double plusOne = 1 + divRN;

            //raise (1 + r/n) to the power of n * t
            double basePwr = Math.Pow(plusOne, multiplyNT);

            //multiply initial amount by (1 + r/n)^(n * t) 
            double compAmount = initAmount1 * basePwr;
            Console.WriteLine("Total Compound Amount: {0:C2}", compAmount);

            return; //return none
        }
    }
    class Program
    {
        static void Main()
        {
            //Calculation.InterestRate();
            Calculation.CompoundInterestRate();
        }
    }

}



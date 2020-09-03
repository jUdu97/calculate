using System;

namespace Calculation
{
    class Calculation
        ///class with methods to determine total accrued amount of money
        ///which is the principal amount plus interest
    {
        public static decimal ConvertDec(string stringValue)
        {
            ///class method that converts string to decimal value
            
            //converts % rate value to decimal
            decimal newValue = Convert.ToDecimal(stringValue);

            //divide % rate by 100
            decimal decValue = ((decimal)newValue) / 100; 

            return decValue; //return decimal value
        }
        public static bool StringCheck(string input)
        {
            ///class method that check is string is empty or NULL
            
            //store value in variable to check input
            bool checkValue = String.IsNullOrEmpty(input);

            return checkValue; //return bool value
        }

        public static void ContinuousCompoundInterestRate()
        {
            ///class method that calculates Continuous Compound Interest Rate

            double e = 2.71828; //set e equal to constant value

            //initialize P, r, and t variables;
            string initPay1, rate1, timeYrs1;

            //check P string if empty or NULL
            do
            {
                //ask user for initial payment amount
                Console.WriteLine("How much is your initial payment amount? ");
                initPay1 = Console.ReadLine(); //reads initial payment input
                //break if string not empty
                if (!StringCheck(initPay1))
                {
                    break;
                } 
            } while (StringCheck(initPay1));
            int initPay2 = Convert.ToInt32(initPay1); //converts input to integer

            //check R string if empty or NULL
            do
            {
                //ask user for rate as percentage
                Console.WriteLine("What is the rate of your payment (%)? ");
                rate1 = Console.ReadLine(); //reads % rate input
                //break if string not empty
                if (!StringCheck(rate1))
                {
                    break;
                }
            } while (StringCheck(rate1));
            decimal rate2 = ConvertDec(rate1); //converts input to decimal

            //check T string if empty or NULL
            do
            {
                //ask user for length of payment
                Console.WriteLine("How long is your payment for (years)? ");
                timeYrs1 = Console.ReadLine(); //reads length of payment input
                //break if string not empty
                if (!StringCheck(timeYrs1))
                {
                    break;
                }
            } while (StringCheck(timeYrs1));
            int timeYrs2 = Convert.ToInt32(timeYrs1); //converts input to integer

            //multiply rate by time
            double mul = ((double)rate2) * timeYrs2;

            //raise e constant to power of rate * time
            double exponent = Math.Pow(e, mul);
            
            //multiply principal amount by e^(r * t)
            double continuousAmount = initPay2 * exponent;
            //print total amount
            Console.WriteLine("Total Continuous Amount: {0:C2}", continuousAmount);
        }
        public static void CompoundInterestRate()
        {
            ///class method that calculates Compound Interest Rate

            //initialize P, r, n, and t variables
            string initAmount1, rate3, n1, timeYrs3;

            //check P string if empty or NULL
            do
            {
                //ask user for initial payment amount
                Console.WriteLine("Enter initial payment: $");
                initAmount1 = Console.ReadLine(); //reads initial payment input
                //break if string not empty
                if (!StringCheck(initAmount1))
                {
                    break;
                }
            } while (StringCheck(initAmount1));
            int initAmount2 = Convert.ToInt32(initAmount1); //converts input to integer

            //check R string if empty or NULL
            do
            {
                //ask user for rate as %
                Console.WriteLine("Enter rate (%): ");
                rate3 = Console.ReadLine(); //reads % rate input
                //break if string not empty
                if (!StringCheck(rate3))
                {
                    break;
                }
            } while (StringCheck(rate3));
            decimal rate4 = ConvertDec(rate3); //converts input to decimal

            //check N string if empty or NULL
            do
            {
                //ask user for number of installments paid
                Console.WriteLine("Enter numbers of times paid: ");
                n1 = Console.ReadLine(); //reads  input of number of payments made
                //break if string not empty
                if (!StringCheck(n1))
                {
                    break;
                }
            } while (StringCheck(n1));
            int n2 = Convert.ToInt32(n1); //converts input to integer

            //check T string if empty or NULL
            do
            {
                //ask user how long their payment plan is
                Console.WriteLine("Enter payment length (years): ");
                timeYrs3 = Console.ReadLine(); //reads length of payment input
                //break if string not empty
                if (!StringCheck(timeYrs3))
                {
                    break;
                }
            } while (StringCheck(timeYrs3));
            int timeYrs4 = Convert.ToInt32(timeYrs3); //converts input to integer

            //multiply number of payments by plan length 
            double multiplyNT = n2 * timeYrs4;

            //divide rate by number of payments
            double divRN = ((double)rate4) / n2;

            //add 1 to r/n
            double plusOne = 1 + divRN;

            //raise (1 + r/n) to the power of n * t
            double basePwr = Math.Pow(plusOne, multiplyNT);

            //multiply initial amount by (1 + r/n)^(n * t) 
            double compAmount = initAmount2 * basePwr;
            //print total amount
            Console.WriteLine("Total Compound Amount: {0:C2}", compAmount);
        }

        public static void ChooseType()
        {
            ///class method that asks user to choose which formula to choose
           
            //print introduction and choices
            Console.WriteLine("Interest App");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Compound Interest: A = P (1 + r/n)^(nt) \t - (1)");
            Console.WriteLine("Continuously Compound Interest: A = P e^rt) \t - (2)");
            Console.WriteLine("----------------------\n");

            //ask user for their choice of formula
            Console.WriteLine("Enter your choice of interest rate formula: ");
            string getChoice = Console.ReadLine(); //reads user input for formula choice

            //loop while choice isn't 1 or 2
            while (getChoice != "1" || getChoice != "2")
            {
                Console.WriteLine("Not a choice. Try again!"); //print error message
                //ask user for input again
                Console.WriteLine("Enter your choice of interest rate formula: ");
                getChoice = Console.ReadLine(); //read user input again

                //condition for choice 1
                if (getChoice == "1")
                {
                    //call Compound Interest Rate Amount
                    CompoundInterestRate();
                    break;
                }
                //condition for choice 2
                else if (getChoice == "2")
                {
                    //call Continuous Compound Interest Rate Amount
                    ContinuousCompoundInterestRate();
                    break;
                }
            }   
        }
    }
    class Program
    {
        static void Main()
        {
            //call to choice of Interest Rate Amount equation type
            Calculation.ChooseType();
        }
    }

}



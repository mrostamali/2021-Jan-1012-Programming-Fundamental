using System;

namespace LoanQualifier
{
    class Program
    {
        static void Main(string[] args)
        {

            //mine way 
            //declare variables
            //propmt user for wage
            //prompt user for year

            //double wage;
            //double year;
            //double LoanAmount = 35000.00;

            //Console.Write("Enter your annual salary here:\t");
            //Console.Write("Enter how many year have you been working?");

            //if (wage > 30000.00)
            //{
            //    if (year > 2)
            //    {
            //        Console.WriteLine("You are qualify for the loan");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You are not qualify for loan due to lack of working years.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("You are not qualify fro loan due to lack of wages.");
            //}



            //for don is correct
            const double MINWAGEAMOUNT = 30000.00;
            const int MINYEARSWORKED = 2;
            double wageAmount = 35000.00; // use this amount to make a test on our code
            int yearWorked = 3; // use this amount to make a test on our code

            if(wageAmount < MINWAGEAMOUNT)
            {
                if(yearWorked < MINYEARSWORKED)
                {
                    Console.WriteLine("Not qualified for loan due to lack of wages and years worked.");
                }
                else
                {
                    Console.WriteLine("Not qualified for loan due to low wages.");
                }
            }
            else
            {
                if (yearWorked < MINYEARSWORKED)
                {
                    Console.WriteLine("Not qualified for loan due to lack of years worked");
                }
                else
                {
                    Console.WriteLine("You qualified for loan.");
                }
            }

        }//eoMain
    }//eop
}//eon

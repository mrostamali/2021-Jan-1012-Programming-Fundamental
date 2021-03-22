using System;

namespace loopProblems
{
    class Program
    {
        static void Main(string[] args)
        {


            ////MoneyMaker
            ////this program will accept a principal investment amount, a monthly interest rate, and an investment time in months
            ////the program will display a monthly investment report using the incoming data 
            ////this program will continue until the user enters an x to exit

            ////Process: Declare/assignment starting variables
            ////         request execution or exit from the user 
            ////         on exit terminate program
            ////         on execution we gonna have: 
            ////                                    input investment values
            ////                                    internate monthly earnings and reports
            ////                                    on termination of investment period, display a summary

            ////This example is one of using nested loops
            ////menue loop will be a post-test loop
            ////investment loop will be a pre-test loop using for() loop
            ////output will demonstration formating of values and columns

            //decimal myPrincipal = 0.0m; //the m "types" this numeric as a decimal
            //decimal myMonthlyInterestRate = 0.0m;
            //Int32 myInvestmentTime = 0; //Int32 is equalivant to int 

            //string menueChoice = "";

            //do
            //{
            //    Console.WriteLine("Welcome to CPSC Investment:\n\n");
            //    Console.WriteLine("a) investment:");
            //    Console.WriteLine("x) to exit:\n");
            //    Console.Write("Enter your menue choice:\t");
            //    menueChoice = Console.ReadLine();

            //    switch(menueChoice.ToUpper())
            //    {
            //        case "A":
            //            {
            //                //for this example I will assume valid data is entered 
            //                Console.Write("\nEnter your principal investment amount:\t");
            //                string inputTemp = Console.ReadLine();
            //                myPrincipal = decimal.Parse(inputTemp);
            //                Console.Write("\nEnter your investment monthly rate (3% -> 0.03):\t");
            //                inputTemp = Console.ReadLine();
            //                myMonthlyInterestRate = decimal.Parse(inputTemp);
            //                Console.Write("\nEnter your investment period in months:\t");
            //                inputTemp = Console.ReadLine();
            //                myInvestmentTime = Int32.Parse(inputTemp);

            //                //use a loop for a fix amount of iterations
            //                //best candidate would be a pre-test loop:
            //                //  a) While with a counter
            //                //  b) for(...) loop   my choice!!!!!
            //                for (int monthcounter = 0; monthcounter < myInvestmentTime; monthcounter++) //counter=counter+1  -> counter++
            //                //OR : for (int monthcounter = 1; monthcounter <= myInvestmentTime; monthcounter++)
            //                {
            //                    //the {0} is refered to as a placeholder
            //                    //the string.Format(format pattern, value for the pattern)
            //                    //pattern is currency and the 0 indicates a placeholder for the value in the .Format method
            //                    Console.Write("\nOpening; {0}\t", string.Format("{0:c}", myPrincipal));

            //                    //.ToString("pattern")
            //                    //# indicate a digit position and is optional, printed if NOT zero (0)
            //                    //0 indicate a digit posotion and is required , zeroes are printed
            //                    Console.Write("Interest Paid: {0}\t", (myPrincipal* myMonthlyInterestRate).ToString("$###,##0.00"));

            //                    myPrincipal += myPrincipal * myMonthlyInterestRate;

            //                    //{variable,xcolumnwidth:pattern}
            //                    //variable is myPrincipal
            //                    // x column width is 15 spaces, positive value is right align, negative value is left align 
            //                    //c stands for currency with a $ sign
            //                    Console.Write($"Closing: {myPrincipal,15:c}\n");
            //                    //OR  --> Console.Write($"Closing: {myPrincipal,15: $###,##0.00}\n");
            //                }
            //                Console.WriteLine($"Closing {myPrincipal.ToString("c"),20}");
            //                break;
            //            }
            //        case "X":
            //            {
            //                Console.WriteLine("\n Thank you. Good-Bye.\n");
            //                break;
            //            }
            //        default:
            //            {
            //                Console.WriteLine("\nYour entry for the menue choice is invalid. Try again\n.");
            //                break;
            //            }
            //    }

            //} while (menueChoice.ToLower() != "x");
            //string msg = "Good luck on your future investments.";
            //for (int i=0; i<msg.Length; i++)
            //{
            //    Console.Write("*");
            //}
            //Console.WriteLine($"\n{msg}\n");
            //for(int i=0; i< msg.Length; i++)
            //{
            //    Console.Write("*");
            //}





            //Code without comment

            decimal myPrincipal = 0.0m;
            decimal myMonthlyInterestRate = 0.0m;
            Int32 myInvestmentTime = 0;
            string menueChoice = "";

            do
            {
                Console.WriteLine("Welcome to CPSC Investment:\n\n");
                Console.WriteLine("a) investment:");
                Console.WriteLine("x) to exit:\n");
                Console.Write("Enter your menue choice:\t");
                menueChoice = Console.ReadLine();

                switch (menueChoice.ToUpper())
                {
                    case "A":
                        {
                            Console.Write("\nEnter your principal investment amount:\t");
                            string inputTemp = Console.ReadLine();
                            myPrincipal = decimal.Parse(inputTemp);
                            Console.Write("\nEnter your investment monthly rate (3% -> 0.03):\t");
                            inputTemp = Console.ReadLine();
                            myMonthlyInterestRate = decimal.Parse(inputTemp);
                            Console.Write("\nEnter your investment period in months:\t");
                            inputTemp = Console.ReadLine();
                            myInvestmentTime = Int32.Parse(inputTemp);

                            for (int monthcounter = 0; monthcounter < myInvestmentTime; monthcounter++)
                            //OR : for (int monthcounter = 1; monthcounter <= myInvestmentTime; monthcounter++)
                            {
                                Console.Write("\nOpening; {0}\t", string.Format("{0:c}", myPrincipal));
                                Console.Write("Interest Paid: {0}\t", (myPrincipal * myMonthlyInterestRate).ToString("$###,##0.00"));
                                myPrincipal += myPrincipal * myMonthlyInterestRate;
                                Console.Write($"Closing: {myPrincipal,15:c}\n");
                            }
                            Console.WriteLine($"Closing {myPrincipal.ToString("c"),20}");
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("\nThank you. Good-Bye.\n");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nYour entry for the menue choice is invalid. Try again\n.");
                            break;
                        }
                }

            } while (menueChoice.ToLower() != "x");
            string msg = "Good luck on your future investments.";
            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine($"\n{msg}\n");
            for (int i = 0; i < msg.Length; i++)
            {
                Console.Write("*");
            }



        }
    }
}

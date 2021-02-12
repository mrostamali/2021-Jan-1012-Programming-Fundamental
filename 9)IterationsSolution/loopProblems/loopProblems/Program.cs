using System;

namespace loopProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //MoneyMaker
            //this program will accept a principal investment amount, a monthly interest rate, and an investment time in months
            //the program will display a monthly investment report using the incoming data 
            //this program will continue until the user enters an x to exit

            //Process: Declare/assignment starting variables
            //         request execution or exit from the user 
            //         on exit terminte program
            //         on execution 
            //         input investment values
            //         internate monthly earnings and reports
            //         on termination of investment period, display a summary

            //this example is one of using nested loops
            //menue loop will be a post-test loop
            //investment loop will be a pre-test loop using for()
            //output will demonstration formating of values and columns

            decimal myPrincipal = 0.0m; //the m "types" this numeric as a decimal
            decimal myMonthlyInterestRate = 0.0m;
            Int32 myInvestmentTime = 0; //Int32 is equalivant to int 

            string menueChoice = "";

            do
            {
                Console.WriteLine("Welcome to CPSC Investment:\n\n");
                Console.WriteLine("a) investment:");
                Console.WriteLine("x) to exit:\n");
                Console.Write("Enter your menue choice:\t");
                menueChoice = Console.ReadLine();

                switch(menueChoice.ToUpper())
                {
                    case "A":
                        {
                            //for this example I will assume valid data is entered 
                            Console.Write("\nEnter your principal investment amount:\t");
                            string inputTemp = Console.ReadLine();
                            myPrincipal = decimal.Parse(inputTemp);
                            Console.Write("\nEnter your investment monthly rate (3% -> 0.03):\t");
                            inputTemp = Console.ReadLine();
                            myMonthlyInterestRate = decimal.Parse(inputTemp);
                            Console.Write("\nEnter your investment period in month:\t");
                            inputTemp = Console.ReadLine();
                            myInvestmentTime = Int32.Parse(inputTemp);

                            //use a loop for a fix amount of iterations
                            //best candidate would be a pre-test loop
                            //a) While with a counter
                            //b) for(...) loop   my choice!!!!!
                            for (int monthcounter = 0; monthcounter < myInvestmentTime; monthcounter++) //counter=counter+1  -> counter++
                            {
                                //the {0} is refered to as a placeholder
                                //ther string.Format (format pattern, value for the patter)
                                //pattern is currency and the 0 indicates a placeholder for the value in the .Format method
                                Console.Write("\nOpening; {0}\t", string.Format("{0:c}", myPrincipal));

                                //.ToString("pattern")
                                //# indicate a digit position and is optional, printed if NOT zero (0)
                                //0 indicate a digit posotion and is required , zeroes are printed
                                Console.Write("Interest Paid: {0}\t", (myPrincipal* myMonthlyInterestRate).ToString("$###,##0.00"));

                                myPrincipal += myPrincipal * myMonthlyInterestRate;

                                //{variable,xcolumnwidth:pattern}
                                //variable is myPrincipal
                                // x column width is 15 spaces, positive value is right align, negative value is left align 
                                //c stands for currency with a $ sign
                                Console.Write($"Closing: {myPrincipal,15:c}\n");
                                //Console.Write($"Closing: {myPrincipal,15: 0: $###,##0.00}\n");
                            }

                            Console.WriteLine($"Closing {myPrincipal.ToString("c"),20}");
                            break;
                        }
                    case "x":
                        {
                            Console.WriteLine("\n Thank you. Good-Bye.");
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
            for (int i=0; i<msg.Length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine($"\n{msg}\n");
            for(int i=0; i< msg.Length; i++)
            {
                Console.Write("*");
            }






        }
    }
}

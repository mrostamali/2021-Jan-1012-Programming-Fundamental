using System;

namespace ArithmeticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //the special character \n adds an extra blank line
            //it is call the next line character
            Console.WriteLine("Arithmetic Samples\n");

            //declare a variable of datatype double
            //syntax;   datatype variablename assignment operator literal numeric value;
            //              double      Total           =           0.0
            double Total = 0.0;
            double Cost = 15.23;
            double Tax = 0.81;

            //arithmetic assignment operation
            //syntax;   receiving variable assignment operator binary arithmetic (Addition) expression
            //                          Total           =           Cost + Tax
            //action: the expression will be executed and the results will be placed into the receiving variable
            Total = Cost + Tax;

            Console.WriteLine($"The result of {Cost} + {Tax} is {Total}");

            //An alternate of outputting your variables will be to use string concatenation
            //string concatenation uses the operator +
            Console.WriteLine("The result of" + Cost + " + " + Tax + " is " + Total);

            //An alternate way is to use placeholders
            //placeholders start at0 and increment by 1
            //placeholder value are in a list after the string
            //ORDER IS IMPORTANT
            Console.WriteLine("The result of {0} + {1} is {2}",Cost,Tax,Total);

        }
    }
}

using System;

namespace InputOutputMath
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Implement a tempereture converter from
             * Celsius to Fahrenheit
             * 
             * Jan 2021
             */

            //input: Celsius tempereture
            //      String inputTemp
            //      double theCelsius Tempereture

            //output: Fahrenheit tempereture
            //      double theFahrenheitTempereture

            //expression (calculation):     (ct * (9.0/5.0)) + 32
            //check with ct = 0 expect ft = 32
            //check with ct = 100 expect ft = 212
            //check with ct = -40 expect ft = -40

            //prompt for a celsius tempereture
            //  .write() keeps your cursor on the same line
            Console.Write("Enter a Celsius tempereture: ");

            //How does the program pull in the entry from the user
            //to obtain the key stokes that the user types (input)
            //  .ReadLine()
            //important!!!
            //  data comes into the program as a string
            //  DOES NOT matter if you enter a number, it is treat as a string

            //declare the variable:     datatype variablename;
            string inputTemp;
            //assignment statement:     expression on the right is placed into the variable on the left
            //expression (action):      read the user input
            inputTemp = Console.ReadLine();

            //you could do both statements on one line
            //string inputTemp = Console.ReadLine();

            //currently the celsius value is a string
            //the value needs to be converted to a number to be used in a math calculation
            //convert the data to a different datatype
            //to do this; you will use technique called parsing
            //  syntax: datatypeTo.Parse(string value)

            //WARNING: I am assuming the user will enter valid data
            //      if user does not enter a number this program will abort on the execution of this line

            double theCelsiusTempereture = double.Parse(inputTemp);

            //calculation using the conversion expression
            double theFahrenheitTemperature = (theCelsiusTempereture * (9.0/5.0)) + 32;

            //output
            //  .WriteLine() which automaticaly goes to the next line.
            Console.WriteLine($"The Celsius temperature of {theCelsiusTempereture} is {theFahrenheitTemperature} in Fahrenhiet.");
        }
    }
}

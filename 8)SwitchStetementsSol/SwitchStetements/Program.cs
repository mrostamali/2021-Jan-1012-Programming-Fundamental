using System;

namespace SwitchStetements
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputTemp;
            Console.Write("Enter an integer:\t");
            inputTemp = Console.ReadLine();
            int number = int.Parse(inputTemp);

            //Case Structure
            //Examines a value/expression against another value in the == scenario
            switch (number)
            {
                case 1:
                     {
                            Console.WriteLine($"Case1 : You entered a number from 1 to 3: {number}");
                            break; //break takes you to the next executable statement after the switch
                     }
                case 2:
                     {
                             Console.WriteLine($"Case1 : You entered a number from 1 to 3: {number}");
                             break; //break takes you to the next executable statement after the switch
                     }
                case 3:
                     {
                             Console.WriteLine($"Case1 : You entered a number from 1 to 3: {number}");
                             break; //break takes you to the next executable statement after the switch
                     }
                default:
                     {
                             //This last coding block is executed If All other cases have faild
                             Console.WriteLine($"Default : You entered a number outside of 1 to 3: {number}");
                               break;
                     }        
            }//eo switch



            //if(number == 1)
            //{
            //    Console.WriteLine("1 st If in if-else-if");
            //}
            //else if (number ==2)
            //{
            //    Console.WriteLine("Second If in if-else-if");
            //}
            //else if (number ==3)
            //{
            //    Console.WriteLine("Third If in if-else-if");
            //}
            //else
            //{
            //    Console.WriteLine("");
            //}
        }
    }
}

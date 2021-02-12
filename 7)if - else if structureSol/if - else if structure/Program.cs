using System;

namespace if___else_if_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            //if - else if structure

            //int testScore = 75;
            //if (testScore < 50)
            //{
            //    Console.WriteLine("Your grade is E.");
            //}
            //else if (testScore < 60)
            //{
            //    Console.WriteLine("Your grade is D.");
            //}
            //else if (testScore < 70)
            //{
            //    Console.WriteLine("Your garde is C.");
            //}
            //else if (testScore < 80)
            //{
            //    Console.WriteLine("Your garde is B.");
            //}
            //else
            //{
            //    Console.WriteLine("Your garde is A.");
            //}//End of IF structure


            //mine way
            //int temperatureinFah;
            //int temperatureinCel;
            

            //Console.Write("Enter a Fahrenheit Temperatute: ");
            //string inputTemp = Console.ReadLine();
            //temperatureinFah = int.Parse(inputTemp);
            //temperatureinCel = (temperatureinFah - 32) * 5 / 9;

            //if (temperatureinCel<0)
            //{
            //    Console.WriteLine("It'is freezing out!");
            //}
            //else if (temperatureinCel<15)
            //{
            //    Console.WriteLine("Wear a jacket.");
            //}
            //else if (temperatureinCel<30)
            //{
            //    Console.WriteLine("It'is a lovely day!");
            //}
            //else
            //{
            //    Console.WriteLine("It'is finally summer!");
            //}//End of If - else if structure


            //don way
            //recode as a range
            int temperatureinFah;
            int temperatureinCel;


            Console.Write("Enter a Fahrenheit Temperatute: ");
            string inputTemp = Console.ReadLine();
            temperatureinFah = int.Parse(inputTemp);
            temperatureinCel = (temperatureinFah - 32) * 5 / 9;

            if (temperatureinCel < 0)
            {
                //below 0
                Console.WriteLine("It'is freezing out!");
            }
            else if ((temperatureinCel >= 0) && (temperatureinCel <= 15))
            {
                //0 yo 15
                Console.WriteLine("Wear a jacket.");
            }
            else if (temperatureinCel >= 16 && temperatureinCel <= 30)
            {
                //16 to 30
                Console.WriteLine("It'is a lovely day!");
            }
            else
            {
                //over 30
                Console.WriteLine("It'is finally summer!");
            }//End of If - else if structur



        }//EoMain
    }//Eop
}//Eon

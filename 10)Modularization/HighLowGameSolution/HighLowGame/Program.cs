using System;

namespace HighLowGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question: Create a console program to play the game of High/ Low to guess a number between a given range.
            //Methods:
            //Main() driver for the program
            //DisplayMenu() displays the driver menu and returns the menu selection
            //InputNumeric() displays a prompt, validates numeric entered, returns numeric value
            //MakeGuess() receives low range, high range, target number; prompts for guess, checks guess, returns string low, high, correct.

            //Driver

            //any local variable within a method is "alive" 
            //   only as long as the method is also "alive"
            //Variables between methods may have the same name BUT are local to
            //   the method the variable exists in (term is called: scope)
            //The inputTemp in Main Method is different from the inputTemp in other Methods
            string inputTemp = " ";
            int lowerRange = 1;
            int highRange = 10 ;
            int target = 0;
            const string CORRECT = "correct";
            Random rnd = new Random();
            bool playGame = false;
            do
            {
                inputTemp = DisplayMenu();
                switch (inputTemp.ToLower())
                {
                    case "a":
                        {
                            //prompt for the game's lower range
                            lowerRange = InputNumeric("Enter the number for the lower range limit:");
                            //prompt for the game's higher range
                            highRange = InputNumeric("Enter the number for the higher range limit:");
                            //could test to see if lower + 1 < higher
                            //Why ensures that you have spread of 3 possible numbers ( lower 4, upper 6)
                            //ensures that the player did not entry the high number then the lower number just to mess up your program
                            Console.WriteLine($"Your range is from {lowerRange} to {highRange}.");
                            playGame = true;
                            break;
                        }
                    case "b":
                        {
                            if(playGame == false)
                            {
                                //OR we can say if (target == 0)
                                Console.WriteLine("Please set your range before playing the game.");
                            }
                            else
                            {
                                //scope: within the case coding block
                                int guessCount = 0;
                                string guessResult = "";

                                //a random number within the range 
                                target = rnd.Next(lowerRange, highRange + 1);
                                while (!guessResult.Equals(CORRECT))
                                {
                                    guessCount++;
                                    guessResult = MakeGuess(lowerRange, highRange, target);
                                    if (!guessResult.Equals(CORRECT))
                                    {
                                        Console.WriteLine($"You did not guess correctly. Your guess is too {guessResult}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"\nCorrect. The secret number was {target}. It took you {guessCount} times to guess the number. \n");
                                    }
                                }
                            
                            }
                            break;
                        }
                    case "x":
                        {
                            Console.WriteLine("\nThank you for playing our game. Please play again.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\n Invalid menu choice. Try again. \n");
                            break;
                        }
                }
            } while (!inputTemp.ToLower().Equals("x"));
            //while(!(inputTemp.ToLower() == "x"))
            //while(inputTemp.ToLower() != "x"))
            //while(inputTemp != "x" || inputTemp != "X")
        }




        //A method stub is the method header and any return statement that is required
        //There is no logic in the method stub
        //It is a skeleton setup for the required method 
        //this allows the call statement to the method to be coded elsewhere in your 
        //    program so the program will compile
        static string DisplayMenu()
        {
            //Methods that return a value are also known as functions 
            //Methods that do not return value are also known as subroutines  

            //string inputTemp ="";
            Console.WriteLine("\nHigh/Low Guessing Game\n");
            Console.WriteLine(" a) Set range");
            Console.WriteLine(" b) Play game");
            Console.WriteLine(" x) Exit");
            Console.Write("\nEnter your menu choice:\t");
            //inputTemp = Console.ReadLine();
            //return inputTemp;
            return Console.ReadLine();
        }


        static int InputNumeric(string prompt)
        {
            //any local variable within a method is "alive" 
            //   only as long as the method is also "alive"
            //Variables between methods may have the same name BUT are local to
            //   the method the variable exists in (term is called: scope)
            string inputTemp = "";
            int aNumber = 0;

            //you might see logic that sets a boolean Value (commonly called a flag)
            //   and the loop condition test to see if the value indicates another iteration is required 
            bool flag = false;

            while(flag == false)
            {
                Console.Write($"{prompt}\t");
                inputTemp = Console.ReadLine();

                //xxx.TryParse(input string, out output conversion)
                //returns true if successful and does the conversion 
                //returns false if not able to convert and DOES NOT do the conversion
                //if(int.TryParse(inputTemp, out aNumber) == false) OR if(int.TryParse(inputTemp, out aNumber) == true) It is opt to me
                //if (!int.TryParse(inputTemp, out aNumber))
                if (int.TryParse(inputTemp, out aNumber))
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine($"Your input of >{inputTemp}< is not a whole number (ex 5).");
                }
            }
            return aNumber;
        }



        static string MakeGuess(int low, int high, int target)
        {
            int guessNumber = 0;
            string guessResult = "";
            const string CORRECT = "correct";
            guessNumber = InputNumeric($"Guess a number between {low} and {high}");
            if(guessNumber == target)
            {
                guessResult = CORRECT;
            }
            else if(guessNumber < target)
            {
                guessResult = "Low";
            }
            else
            {
                guessResult = "High";
            }
            return guessResult;
        }

    }
}

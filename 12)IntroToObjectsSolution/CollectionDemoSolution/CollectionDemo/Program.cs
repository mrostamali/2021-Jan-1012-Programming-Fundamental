using System;

#region Additional Namespaces
using System.Collections.Generic; //needed for List<T> classes
using static System.Console;  //need for WriteLine, ReadLine and write
#endregion
namespace CollectionDemo
{
    class Program
    {
        //entry point into your console application software.
        static void Main(string[] args)
        {
            //BasicsOfLists();

            //using composite classes
            //class room
            //   within the class we have: Wall, Opening, List<T> (List of T is a class itself)

            //create a collection of Walls for the room
            //When the List<T> is created the inctance will be empty it means (Count == 0)

            List<Wall> Walls = new List<Wall>();
            Walls = InputWallsForRoom();
            //OR
            //  InputWallsForRoom(Walls);
            List<Opening> openings = new List<Opening>();


        }


        static List<Wall> InputWallsForRoom()
        {
            //NOTE: If you create a new instance in the main instead of in the loop
            //   and you want to have multiple instances by user prompt it just get 
            //   the last value for all the instances and it makes a problem be careful
            //   to create your instance in the loop if you want to have multiple instances
            //  It is wrong to declare in the main when you want multiple instances  ( Wall aWall = new Wall(); )
            //Declare a variable capable of holding an instance of the class Wall
            Wall aWall = null;
            //You need to create a local List<T> BECAUSE 
            //   you DID NOT pass in the collection to be filled
            //you will return the local List<T>
            List<Wall> inputWalls = new List<Wall>();
            bool finished = false;
            do
            {
                //to create a NEW UNIQUE instance of the class Wall, use the new operator and the class name
                //the new operator will use the Wall default constructor
                aWall = new Wall();  //it is a single instance
                //obtain the width for the wall
                aWall.Width = GetPositiveDouble("Enter the width of your wall:\t");
                //obtain the height for the wall
                aWall.Height = GetPositiveDouble("Enter the height of your wall:\t");
                //Add the instance to the wall collection
                inputWalls.Add(aWall);
                if (GetNonEmptyString("Do you want another wall, Y or N.").ToUpper().Equals("N"))
                {
                    finished = true;
                }
            } while ( !finished );
            //return the wall collection
            return inputWalls;
        }


        static double GetPositiveDouble (string prompt)
        {
            double number = 0;
            string inputTemp = null;
            bool valid = false;
            do
            {
                Write($"{prompt}\t");
                inputTemp = ReadLine();
                if (double.TryParse(inputTemp, out number))
                {
                    if(number > 0)
                    {
                        valid = true;
                    }
                    else
                    {
                        WriteLine($"Input is invalid {inputTemp}. Not a positive number. Try again..");
                    } 
                }
                else
                {
                    WriteLine($"Input is invalid {inputTemp}. Try again.");
                }
            } while (!valid);
            return number;
        }


        static string GetNonEmptyString(string prompt)
        { 
            string inputTemp = null;
            bool valid = false;
            do
            {
                Write($"{prompt}\t");
                inputTemp = ReadLine();
                if (!string.IsNullOrEmpty(inputTemp))
                {
                    valid = true;
                }
                else
                {
                    WriteLine($"Input is empty. Try again to enter a string of characters.");
                }
            } while (!valid);
            return inputTemp;
        }






        static void BasicsOfLists()
        {
            //declare a List<T> where <T> is your datatype 
            List<int> setOfNumbers = new List<int>();
            //add element to a list
            setOfNumbers.Add(55);
            setOfNumbers.Add(41);
            setOfNumbers.Add(100);
            int number = 78;
            setOfNumbers.Add(number + 1);  //OR setOfNumbers.Add(number);  as long as it is the same dataype as our list

            //display the current number of items in the list .Count
            WriteLine($"The list contains {setOfNumbers.Count} elements");

            //traverse a List<T>
            for (int i = 0; i < setOfNumbers.Count; i++)
            {
                WriteLine($"the list item {i + 1} is {setOfNumbers[i]}");
            }

            //Sort a list
            //  "for two element x and y do the following"
            //  ascending sort is x vs y
            //  descending sort is y vs x

            // Ascending:
            setOfNumbers.Sort((x, y) => x.CompareTo(y));

            // Descending
            //setOfNumbers.Sort((x, y) => y.CompareTo(x));


            //This is a Pre-test loop
            //System checks to see if there is an element in the list 
            //if there is an element(s) in the list, each element is accessed 
            //   one at a time, from start to end, and the element is processed 
            //   by the logic in the loop coding block
            //The system checks for the end of the list and stops automatically
            foreach (int listElement in setOfNumbers)
            {
                //while in the loop you refrence the current element via your 
                //   placeholder (variable)
                WriteLine($"\nthe list item is {listElement}");
            }


            //Removing from a list<T>
            setOfNumbers.Remove(number + 1);
            foreach (int listElement in setOfNumbers)
            {
                WriteLine($"\nthe list item is {listElement}");
            }

        }
    }
}

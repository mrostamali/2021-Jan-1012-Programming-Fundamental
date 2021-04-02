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
            List<Opening> Openings = new List<Opening>();
            WriteLine($"Before load: Number of Walls {Walls.Count,5} Number of Openings {Openings.Count,-5}\n\n");

            //Loading using a returened List<T>
            Walls = InputWallsForRoom();  //OR InputWallsForRoom(Walls);


            //Loading using a List<T> as a method parameter argument
            InputOpeningsForRoom(Openings);
            WriteLine($"After load: Number of Walls {Walls.Count, 5} Number of Openings {Openings.Count,-5}");

            //create and load a class called Room
            //Room is a composite class
            //a composite class is identified bu using other classes within its definition
            string name = GetNonEmptyString("Enter the name of the room:");
            string color = GetNonEmptyString("Enter the paint color for the room:");
            Room myRoom = null;
            try
            {
                //third way of creating and loading an instance
                //Attach a coding block to your new statement
                //It does NOT MATTER if your class has OR has not got codded constructors to be able to use this technique.
                //NOTE: not well formed if you are trying to use a "greedy" constructor
                myRoom = new Room()
                {
                    //syntax :
                    //  class propertyname = value[ , ....]
                    Name = name,
                    Color = color,
                    Walls = Walls,
                    Openings = Openings
                };

                //find the net area surface of the room
                //sum up all the roo, wall areas
                //sum up all the opening areas
                //  surface area = roomSurfaceArea - openingArea
                double wallSurfaceArea = 0.0;
                double openingArea = 0.0;
                //by using the property walls in the class room, we prove that 
                //   the List<T> (Walls) was truely loaded to the instance of Room
                foreach (Wall item in myRoom.Walls)
                {
                    //item is an instance of the List<Walls> in the collection loades
                    //   to the room instance myRoom
                    wallSurfaceArea += item.WallArea();
                }
                foreach (Opening item in myRoom.Openings)
                {
                    //item is an instance of the List<Walls> in the collection loades
                    //   to the room instance myRoom
                    openingArea += item.OpeningArea();
                }
                WriteLine($"\n\nTotal wall area {wallSurfaceArea} Total opening are {openingArea} giving a net surface area to point the color" +
                    $"of {myRoom.Color} of {wallSurfaceArea - openingArea} in the room {myRoom.Name}\n\n");

            }
            catch(Exception ex)
            {
                WriteLine($"\nError: {ex.Message}\n");
            }

        }


        static List<Wall> InputWallsForRoom()
        {
            
            //Declare a variable capable of holding an instance of the class Wall
            Wall aWall = null;
            //You need to create a local List<T> BECAUSE 
            //   you DID NOT pass in the collection to be filled
            //you will return the local List<T>
            List<Wall> inputWalls = new List<Wall>();
            bool finished = false;
            do
            {
                //NOTE: If you create a new instance in the main instead of in the loop
                //   and you want to have multiple instances by user prompt it just get 
                //   the last value for all the instances and it makes a problem be careful
                //   to create your instance in the loop if you want to have multiple instances
                //  It is wrong to declare in the main when you want multiple instances  ( Wall aWall = new Wall(); )
                //to create a NEW UNIQUE instance of the class Wall, use the new operator and the class name
                //the new operator will use the Wall default constructor

                //Step1 : create the instance
                aWall = new Wall();  //it is a single instance
                //Note: it is so important to create this instance here in the loop not in the main method

                //Step 2: collect data and load the instance
                //obtain the width for the wall
                aWall.Width = GetPositiveDouble("Enter the width of your wall:\t");
                //obtain the height for the wall
                aWall.Height = GetPositiveDouble("Enter the height of your wall:\t");

                //Step 3: Save the instance
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


        static void InputOpeningsForRoom(List<Opening> Openings)
        {
            Opening anOpening = null;
            bool finished = false;
            double Width = 0.0;
            double height = 0.0;
            string description = null;
            do
            {
                //loading using the "greedy" constructor
                //need to have all values for the instance BEFORE creating the 
                //   actually instance (via new)
                
                //Step 1: Collect data
                Width = GetPositiveDouble("Enter the width of your Opening:\t");
                height = GetPositiveDouble("Enter the height of your Opening:\t");
                description = GetNonEmptyString("Enter a description of the opening (such as window, door, fireplace, etc.)");

                //Step 2: Create and load new instance using greedy
                anOpening = new Opening(Width, height, description);

                //Step 3:save the instance
                Openings.Add(anOpening);
                if (GetNonEmptyString("Do you want another opening, Y or N.").ToUpper().Equals("N"))
                {
                    finished = true;
                }
            } while (!finished);
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

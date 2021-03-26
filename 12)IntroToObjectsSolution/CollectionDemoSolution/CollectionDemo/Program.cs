using System;

#region Additional Namespaces
using System.Collections.Generic; //needed for List<T> classes
using static System.Console;  //need for WriteLine, ReadLine and write
#endregion
namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicsOfLists();

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
            setOfNumbers.Add(number+1);  //OR setOfNumbers.Add(number);  as long as it is the same dataype as our list

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

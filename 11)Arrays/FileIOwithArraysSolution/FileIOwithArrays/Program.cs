using System;
using System.IO; //Clarifies the requirement for File I/O 



namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ARRAYSIZE = 100;
            int[] Marks = new int[ARRAYSIZE];
            int logicalSize = 0;
            string inputTemp = "";
            string FullFilePathName = "";

            
            do
            {
                inputTemp = MenuPropmt(); 
                switch (inputTemp.ToUpper())
                {
                    case "A":
                        {
                            FullFilePathName = HardCodedFileName();
                            logicalSize = ProcessFile(FullFilePathName, Marks, ARRAYSIZE);
                            break;
                        }
                    case "B":
                        {
                            //pass the array to the method along with the number of active 
                            //  elements in the array(logical size)
                            DisplayArray(Marks, logicalSize);
                            break;
                        }
                    case "C":
                        {
                            WriteToFile();
                            break;
                        }
                    case "D":
                        {
                            SequenseSearch (Marks,logicalSize);
                            break;
                        }
                    case "E":
                        {
                            BubbleSort(Marks, logicalSize);
                            break;
                        }
                    case "F":
                        {
                            int foundIndex = -1;
                            foundIndex = BinarySearch(Marks, logicalSize);
                            if (foundIndex > -1)
                            {
                                Console.WriteLine($"The value you are searching for is located at index {foundIndex} in the array." +
                                    $"The search value was {Marks[foundIndex]}\n");
                            }
                            else
                            {
                                Console.WriteLine("The search value is not in the array.\n");
                            }
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine("Thank You. Have a nice day.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"{inputTemp} is not a valid menu option. Try Again.");
                            break;
                        }
                }
            } while (inputTemp.ToUpper() != "X");
        }

        static string HardCodedFileName() 
        {

            string Folder_Pathname = @"D:\GitHub\CPSC-1012\FileProcessing\";
            string Full_Path_Filename;
            Full_Path_Filename = Folder_Pathname + @"OneColumn.txt";
            //Full_Path_Filename = Folder_Pathname + @"TwoColumn.txt";
            //Full_Path_Filename = Folder_Pathname + @"BadFileDoesNotExist.txt";
            //Full_Path_Filename = Folder_Pathname + @"VariableColumns.txt";
            return Full_Path_Filename;
        }   


        static int ProcessFile(string paramfullFilePathName, int[] Marks, int physicalSize)
        {
            //Each record will represent an element in the array Marks
            //Therefore the variable "records" will represent the logical number of 
            //   elements used in the array
            int records = 0;
            StreamReader reader = null; 
            try
            {
                reader = new StreamReader(paramfullFilePathName);
                string readline = "";
                readline = reader.ReadLine();
                while (readline != null)
                {
                   
                    Console.WriteLine($"\nContents of file record\t {readline}");
                    int columncounter = 0;
                    foreach (string value in readline.Split(','))
                    {
                        columncounter++;
                        Console.WriteLine($"Column {columncounter} contains the value {value}");

                        //add the data to the appropriate array
                        //Concerns:
                        //    Is there enough room in the array for another value?
                        //    Does the string input need to be converted?
                        if(records < physicalSize)
                        {
                            //There is room for value in the array
                            //ADD the value to the array
                            Marks[records] = int.Parse(value);
                            records++;
                        }
                        else
                        {
                            //creating your own error to handle a "logical" run problem
                            //this is NOT bad logic, it is a user generator problem
                            throw new Exception("Insufficient room for more data in the program");
                        }
                    } 
                    readline = reader.ReadLine();
                }
                Console.WriteLine($"\n You read {records} records.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nYou had a problem reading the file. \n\nError: \t{ex.Message}\n");
            }
            finally
            {
                reader.Close();
            }
            return records;
        }

        static string MenuPropmt()
        {
            string inputTempLocal = "";
            Console.WriteLine("File I/O options:");
            Console.WriteLine("a) Hard-coded file name.");
            Console.WriteLine("b) Display array");
            Console.WriteLine("c) Writing to a file.");
            Console.WriteLine("d) Search an array: Sequence Search.");
            Console.WriteLine("e) Sort an array: Bubble Sort.");
            Console.WriteLine("f) Search an array: Binary Search.");
            Console.WriteLine("x) Exit.\n");
            Console.Write("Enter the menu option for File I/O:\t");
            inputTempLocal = Console.ReadLine();
            return inputTempLocal;
        }

        static void WriteToFile()
        {
            string PathName = @"D:\\GitHub\\CPSC-1012\\FileProcessing\\";
            string FullPathName = PathName + @"NewFile.txt";
            StreamWriter writer;

            try 
            {
                writer = new StreamWriter(FullPathName, true);
                Random rnd = new Random();
                int linesout = rnd.Next(1, 6); 
                for (int looper = 0; looper < linesout; looper++) 
                {
                    
                    writer.Write($"line {looper}, Mohamad\n");
                }
              
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}\n\n");
            }
        }

        static void DisplayArray(int[] Marks,int logicalSize)
        {
            //Traverse the array from the beginning to the end
            //write each element contents to the screen

            //with the while, YOU are responsible for all control of looping
            //   ensuring that you do NOT do beyond the contents of the array
            //The index is the physical position within the array (which element position)
            //     calculation of the element position is arratAddress + (index * element size)
            //The logical size is a natural count of the number of active elements in the array
            //int index = 0;
            //while (index < logicalSize)
            //{
            //    Console.WriteLine($"Element at index {index} has a value of {Marks[index]}");
            //    index++;
            //}


            //all of the seperate line of looping count used for the while loop exists in the 
            //   setup for the for loop
            for (int index = 0; index < logicalSize; index++)
            {
                Console.WriteLine($"Element at index {index} has a value of {Marks[index]}");
            }

            //all the control of the loop is embedded within the software of foreach
            //foreach:
            //     Checks to see if there is anything to process
            //     process the collection (array) from the start to the end!!!!!!
            //     After an iteration, automatically checks to see if another iteration is required
            //     Stops automatically when there is nothing more to process
            //
            //theforeach isolates a single instance of your collection using a placeholder variable
            //during the processing, use the placeholder to obtain the contents of the elements in 
            //   your array that is currently being processed 
            //
            //WARNING!!!!
            //  the foreach loop will process your ENTIRE collect INCLUDING any unused array elements.
            //  if you wish to use this looping and ONLY process the used array elements 
            //   YOU MUST still supply logic to NOT do certain processing for unused elements.
            //foreach (int CurrentElement in Marks)
            //{
            //    Console.WriteLine($"Element has a value of {CurrentElement}");
            //}
        }

        static void SequenseSearch(int[] Marks, int logicalSize)
        {
            int searchValue = InputForInt();

            //
            // setup  for search
            //
            bool foundFlag = false;
            int foundIndex = 0;
            //
            //  search
            //  there are 2 conditions to stop the loop
            //     a) examine all elements
            //     b) did you find all element (if so stop)
            //
            //for (int index = 0; index < logicalSize && !foundFlag; index++) ////start to end
            for (int index = logicalSize - 1; index >= 0 && !foundFlag; index--)   //end to start 
            {
                if (Marks[index] == searchValue)
                {
                    foundFlag = true; //cause the loop to terminate
                    foundIndex = index; // record the element index where your item was found
                }
            }
            //
            //  test search results
            //
            if(foundFlag)
            {
                Console.WriteLine($"\nYou found your value ({searchValue}) in the array element located at index {foundIndex}. " +
                    $"Array Element value is >{Marks[foundIndex]}< \n ");
            }
            else 
            {
                Console.WriteLine($"\n you did not find your value ({searchValue}).\n");
            }
        }
         
        static void BubbleSort(int[] Marks, int logicalSize)
        {
            //temp swap area
            int temp = 0;

            //swap flag (was a swap done on this iteration of the outer loop)
            //if there was no swap done on an iteration of the outer loop, it means
            //  that all required swapping has been done AND the array is in order 
            //this optimize the logic for sorting
            bool swapped = true;

            //loop to ensure every combination in the array is covered 
            //since we known the number of iteration required (logicalSize)
            //   the best looping choice is the for() loop
            for (int allIndex = 0; allIndex < logicalSize -1 && swapped; allIndex++)
            {
                //how many times I iterating through = allIndex
                //the actual comparison loop is the inner loop 
                //this loop need to be done for each iteration of the outer loop
                //reset the swap flag for the array iteration
                swapped = false;


                //In a bubble sort, one compares addjacent elements to determine
                //  if the elements need to be switched
                //To optimize the looping, on each execution of the outer loop 
                //   one can short the number of iterations on the inner loop 
                for (int swapIndex = 0; swapIndex < logicalSize - allIndex -1; swapIndex++)
                {
                    //test to swap
                    //if we are doing ascending order: we should do a greater than test
                    //if we are doing descending order: we should do a less than test
                    if(Marks[swapIndex] > Marks[swapIndex +1])
                    {
                        //extra code to see the swap
                        Console.WriteLine("Pre Swap");
                        DisplayArray(Marks, logicalSize);

                        //swap
                        //move one of the value out of the way (into the swap area)
                        temp = Marks[swapIndex];
                        Marks[swapIndex] = Marks[swapIndex + 1];
                        Marks[swapIndex + 1] = temp;
                        swapped = true;

                        //extra code to see the swap
                        Console.WriteLine("Post Swap");
                        DisplayArray(Marks, logicalSize);
                    }
                }
            }
        }

        static int BinarySearch (int[] Marks, int logicalSize)
        {
            int searchArg = InputForInt();
            int firstIndex = 0;
            int lastIndex = logicalSize - 1;
            int middleIndex = 0;
            //The founIndex is also serving as the flag to indicate that the search 
            //   value has been found
            //Since array do NOT have negative indexes, if the foundIndex is altered
            //  then the logical reason is the index pointto a place in your array 
            //  where your search argument exists.
            int foundIndex = -1;

            //There will be an unknown number of times through the loop 
            //thus the best choice for looping will be the while loop 
            while(firstIndex <= lastIndex && foundIndex == -1)
            {
                
                //find the middle index
                //This must be done using integer arithmetic 
                middleIndex = (firstIndex + lastIndex) / 2;

                Console.WriteLine($"Pre-test: first {firstIndex} Last {lastIndex} Middle {middleIndex}");

                //comparison 
                if (searchArg > Marks[middleIndex])
                {
                    //everything in the SORTED array below the value at the middleIndex 
                    //   And the middleIndex cannot logically be my search argument
                    //therefore the NEW firstIndex is the element after the middleIndex element
                    firstIndex = middleIndex + 1;
                }
                else
                {
                    if(searchArg < Marks[middleIndex])
                    {
                        //everything in the SORTED array above the value at the middleIndex 
                        //   And the middleIndex cannot logically be my search argument
                        //therefore the NEW lastIndex is the element after the middleIndex element
                        lastIndex = middleIndex - 1;
                    }
                    else
                    {
                        //the current middleIndex element of the array is the element that 
                        //  your program is looking for
                        //Thus stop the search
                        //Stopping the search done by changing your foundIndex to a non negative
                        //    value indicating the index location in the array
                        foundIndex = middleIndex;
                    }
                    
                }
                Console.WriteLine($"Post-test: first {firstIndex} Last {lastIndex} Middle {middleIndex}");
            }
            return foundIndex;
        }

        static int InputForInt()
        {
            string inputTemp;
            bool valid = false;
            int value = 0;
            do
            {
                Console.Write("Enter a whole number (ex 5)\t");
                inputTemp = Console.ReadLine();
                if(int.TryParse (inputTemp, out value))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine($"Your value of >{inputTemp}< is invalid. Try again. ");
                }
            } while (!valid);
            return value;
        }

    }
}

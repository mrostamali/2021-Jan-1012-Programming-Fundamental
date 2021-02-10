using System;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            ////pre-test loop structure (a.k.a Do-While structure)
            ////
            //string inputTemp;
            //int aNumber;

            //Console.Write("Enter a number:\t");
            //inputTemp = Console.ReadLine();
            //aNumber = int.Parse(inputTemp);
            //int loopExecutions = 0;
            ////pre-test loop
            //while (aNumber != 0)
            //{
            //    //all code within this coding block ({.....}) belongs to the loop

            //    //a fast way of adding 1 to a counter
            //    //loopExecutions = loopExecutions + 1; (equals to below equation)
            //    loopExecutions++;
            //    Console.WriteLine($"You entered the number {aNumber}");
            //    Console.Write("Enter a number:\t");
            //    inputTemp = Console.ReadLine();
            //    aNumber = int.Parse(inputTemp);
            //}

            ////next statement is the first executable statement after the loop
            //Console.WriteLine($"The loop has finished, you executed the loop {loopExecutions} times.");



            //post-test loop
            //do
            //{
            //    //all code within this coding block ({.....}) belongs to the loop

            //    //a fast way of adding 1 to a counter
            //    //loopExecutions = loopExecutions + 1; (equals to below equation)
            //    loopExecutions++;

            //    Console.Write("Enter a number:\t");
            //    inputTemp = Console.ReadLine();
            //    aNumber = int.Parse(inputTemp);
            //    if (aNumber != 0) //termination number DO NOT PRINT
            //    {
            //        Console.WriteLine($"You entered the number {aNumber}");
            //    }
            //} while (aNumber != 0); //eoehile

            ////next statement is the first executable statement after the loop
            //Console.WriteLine($"The loop has finished, you entered executed the loop {loopExecutions} times.");






            //Assume you are an instructer.
            //Enter a mark for each student in your class.
            //Continue to enter marks for the students and after all marks have been entered calculate the average
            //The highest mark for any student is 100.
            //The lowest mark for any student is 0.

            //requirements:
            //data: counter for marks entered (int)
            // Totaling variable (int)
            //final average variable (rounded(int) or rounded(double,1))

            //processing: itertive logic 
            //prompt, read, sum, check for next entry 
            // what will be the terminating value 
            //could one use a character (string) to terminate ie x
            //calclate and display the number of student and average 

            //declare my variable
            //string inputTemp;
            //int sumOfMarks = 0;
            //int countOfStudents = 0;
            //int inputNumber = 0;

            //////get my first value
            //Console.Write("\nEnter the student mark between 0 and 100 or X to exit:\t");
            //inputTemp = Console.ReadLine();

            ////pre-test loop
            //while (inputTemp.ToUpper() != "X")
            //{
                
            //    sumOfMarks += int.Parse(inputTemp);
            //    countOfStudents++; //fast way to add 1 to a counter
            //    Console.Write("\n\nEnter the student mark between 0 and 100 or X to exit:\t");
            //    inputTemp = Console.ReadLine();
            //}
            //if (countOfStudents == 0)
            //{
            //    Console.WriteLine("You did not enter any student marks.");
            //}
            //else
            //{
            //    Console.WriteLine($"There are {countOfStudents} students. Their average mark is " +
            //        $"{Math.Round((decimal)sumOfMarks / (decimal)countOfStudents, 1)}.");
            //}


            //post-test loop
            //get my first value
            string inputTemp;
            int sumOfMarks = 0;
            int countOfStudents = 0;
            int inputNumber = 0;

            do
            {
                Console.Write("\nEnter the student mark between 0 and 100 or X to exit:\t");
                inputTemp = Console.ReadLine();
                if (inputTemp.ToUpper() != "X")
                {
                    //is the data of the correct datatype
                    if (int.TryParse(inputTemp, out inputNumber))
                    //inputNumber = int.Parse(inputTemp); the previous line help me get rid of this line
                    //Validating that the inputNumber is within the range of 0 to 100
                    {
                        if (inputNumber >= 0 && inputNumber <= 100)
                        {
                            //Assume that data is good
                            sumOfMarks += inputNumber;
                            countOfStudents++; //fast way to add 1 to a counter
                        }
                        else
                        {
                            Console.WriteLine($"your number {inputNumber} is outside the acceptable range of 0 to 100. " +
                                $"Value rejected. Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Your entered value {inputTemp} is not a number or the character x." +
                            $"Your value is invalid and rejected.");
                    }
                }
            } while (inputTemp.ToUpper() != "X");
            if (countOfStudents == 0)
            {
                Console.WriteLine("You did not enter any student marks.");
            }
            else
            {
                Console.WriteLine($"There are {countOfStudents} students. Their average mark is " +
                    $"{Math.Round((decimal)sumOfMarks / (decimal)countOfStudents, 1)}.");
            }

        }
    }
}

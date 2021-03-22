using System;
using System.IO; //Clarifies the requirement for File I/O 



namespace FileIO
{
    class Program
    {
        [STAThread]

        /*Main
          *Main() is a method name
          *It is a special method
          *It is an entry point into your program execution
          */

        /*Static
         *Static is what is called an access mode
         *In Console application it is going to be static 
         *Static means that this method can be shared by other items, it does not change, Just the content in it will change
         *(The taxi will not change, only the customers will change)
         */

        /*Void
         * It is a datatype
         * It means that nothing is gonna turn back from the method (Main)
         * You can change void and return something, but you can only return a single value 
         */

        /*(string[] args)
         * It is called a list of parameters
         * This is the stuff that we can give to the method
         */

        //NOTE : We do not put a method inside a method, we put it inside a class (It is called modularization)
        //My program can have as many Method as I need

        static void Main(string[] args)
        {

            /*
             * Process
             * 
             * this program will demonstrate methods, menu looping and various styles of File I/O
             * 
             * Create a post-loop (do/while) to handle the menu
             *        the menu will have 3 options, one for each type of File I/O style
             *        
             * methods will be used to obtain the file name to be read for this program
             *         the methods will have no incoming parameter, will return a string datatype
             *         
             * the reading and display of the file will be placed in a seperate method
             *         the method will have a string incoming parameter, 
             *         the method will not return anything (void datatype)
             *         the method will demonstrate error handling using Try/Catch/Final
             * 
             */

            string inputTemp ="";
            string FullFilePathName ="";

            //post loop structure, used to control the menu
            do
            {
                inputTemp = MenuPropmt(); //a method containing the menu prompts
                switch (inputTemp.ToUpper())
                {
                    case "A":
                        {
                            //Hard coded file-name
                            //
                            //the calling statement
                            //
                            //optionally [receiving variable =] MethodName([List of arguments)];
                            //
                            //on the calling statement your method's list of parameters are 
                            //Properly referred to as "list of arguments"
                            FullFilePathName = HardCodedFileName();
                            break;
                        }
                    case "B":
                        {
                            FullFilePathName = WindowEnvironmentFileName();
                            break;
                        }
                    case "C":
                        {
                            WriteToFile();
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
                //Console.WriteLine($"\nYour full path name is {FullFilePathName}\n");

                //pass an argument value into a method
                if (!(inputTemp.ToUpper().Equals("X") || inputTemp.ToUpper().Equals("C")))
                {
                    //A calling statement which is supplying a single argument value to the method.
                    //There is NO assignment operator which indicates:
                    //                            a) nothing is being returned from the method OR
                    //                            b) a logic decision has been made to ignore any returned value
                    ProcessFile(FullFilePathName);
                }
            } while (inputTemp.ToUpper() != "X");
        }

        /*Methods
             * Methods
             * 
             * Why we need to use methods????
             *      -To reduce code redundancy
             *      -Break up your code into smaller managable pieces (modularization)
             *      
             * Where do methods go??
             *      -Methods go into your program class
             * 
             * Syntax for a method:
             *      Accesstype returndatatype MethodName ([list of parameters])    --([]) means that the stuff in ([]) is optional
             *      {
             *          Coding block
             *      }
             *  
             *  
             * accesstype?
             *      -This is dependant on what is the Main access type or if the class is NOT the entry point to your entire application,
             *       It could be public, private, internal, protected, ...
             *       
             *       
             * returndatatype? (datatype)
             *      -Methods have been called by many names.
             *      -Methods have been called subroutines, functions, methods.
             *      -Subroutines and functions are different in that: 
             *                                                      --Subroutines return no data to the calling statement;
             *                                                      --Whereas functions will return data to the calling statements.
             *      -The return datatype must be a valid language datatype. (In c# it is gonna be string, int, double ,.... 
             *                                                               whatever language you use it they should be valid)
             *      -The return datatype in C# that returns nothing is the keyword Void.(If you dont want to return anything, Use a keyword Void)
             * 
             * 
             * MethodName?
             *      -This is what the method is called.
             *      -The method name is usually unique. (The method name does not have to be unique as long as the list of parameters is different)
             *      -The method names that are not unique are paired with their list of parameters to create a method signature,
             *      -The method signature MUST be unique.This is referred to as overloaded methods.
             *
             * 
             * [list of parameter] (optional)
             * What is a parameter?
             * consider the parameter a variable within your method that has already been declare and can be used as other variables
             *      -datatype parametername
             *      
             * What is a list of parameters?
             *      -datatype parametername, datatype parametername, ....
             */

        static string HardCodedFileName() //It is called method header 
        {
            //Any locally created variables ARE DESTROYED when the method Terminates
            //local variables have "scope" to the method they exist in

            //setup a path name to the folder on your machine that contains the file to be read
            string Folder_Pathname = @"D:\GitHub\CPSC-1012\FileProcessing\";

            //concatenate a file name to the pathname
            string Full_Path_Filename;
            //Full_Path_Filename = Folder_Pathname + @"OneColumn.txt";
            //Full_Path_Filename = Folder_Pathname + @"TwoColumn.txt";
            //Full_Path_Filename = Folder_Pathname + @"BadFileDoesNotExist.txt";
            Full_Path_Filename = Folder_Pathname + @"VariableColumns.txt";

            //BECAUSE the method indicated a returned datatype of string (anything but void)
            //The methods REQUIRES a return xxxx; Statement
            //If I used Void, I would not need to return a statement
            //I have a string, so I should pass back a statement. I couldnt pass back a number or a boolean or ...
            //the returned value is a physical copy of the contents of the variable on the statement
            //You may return ONLY one value.
            return Full_Path_Filename;
        }

        static string WindowEnvironmentFileName()
        {
            //Using environment.GetFolderPath allows the program to 
            //get to the special folders of your windows file system (DeskTop, Documents, Download, ...)
            string myMachinePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //If you have a folder structure on your Desktop where the file is located 
            //  Then add that path to the MachinePath
            myMachinePath += @"\CPSC1012-FileIO\";
            //Add the actual file name to the full path 
            string Full_Path_Filename;
            //Full_Path_Filename = myMachinePath + @"OneColumn.txt";
            Full_Path_Filename = myMachinePath + @"TwoColumn.txt";
            return Full_Path_Filename;
        }

        static void ProcessFile(string paramfullFilePathName)
        {
            //The parameter on the method header SHOULD be treated as a local variable
            //DO NOT redeclare parameter variables as local variables 
            //If your parameter variable is a VALUE type variable then the name 
            //     given to the passing of data into this method called "Pass By Value"

            //Pass By Value meaning:
            //A physical copy of the data from the call statement is passed into the parameter variable

            //Read the contents of a single column record from a file 
            //The number of records on the file is unknown
            //Include User Freindly Error handling

            int records = 0;

            //StreamReader is used to creat a "pipeline" to your physical file
            //The StreamReader is one of the system.IO classes
            //your code needs to create(request) an "instance" of the class
            //syntax is datatype (datatype also refer to as the classname) StreamReader
            //creating the instance : new theClassname ([list of parameters])
            //  the parameter required is the complete file path name 
            //StreamReader reader = new StreamReader(paramfullFilePathName);
            StreamReader reader = null; //make it two statements and put it in the try

            //User Freindly Error handling
            //use the structure called Try/Catch/[Finally]
            //syntax structure
            //try
            //{
            //   coding to try and execute
            //}
            //catch (Exception ex)
            //{
            //   code use to handle the run time error
            //}
            //[finally]
            //{
            //   code to execute whether there is no error or if there was an error
            //}]
            try
            {
                reader = new StreamReader(paramfullFilePathName);
                //logic of your program
                string readline = "";
                //read the first record from your StreamReader pipeline
                readline = reader.ReadLine();
                //your program will know when you have reached the end of the file 
                //  when it received a null value from the StreamReader method.ReadLine()
                //use pre-test loop
                while(readline !=null)
                {
                    //a line has been returned from the physical file
                    records++;
                    Console.WriteLine($"\nContents of file record\t {readline}");

                    //this code demonstrate a technique to handle multiple values on a single record 
                    //  which are seperated by the comma (',') character
                    //This technique uses
                    //  a) the string method .Split('delimiter')
                    //  b) the pre-test loop called foreach()
                    //a file with records containing multiple values seperated by a comma 
                    // is often referred to as CSV file (Comma Seperated Values)
                    int columncounter = 0;
                    //the foreach loop is nice because
                    //  a) handles an unknown number of times for looping
                    //  b) the while condition is embedded within the loop and is handled as "is there any more to do?" 
                    //  c) stops automatically if there is no more to do
                    //  d) the "item" (data) to process is located in the local loop variable declare in the foreach syntax.
                    //     In this example the local loop variable is string value
                    //  e) the "in" Variable specifies the data source location
                    foreach (string value in readline.Split(','))
                    //We could use | or ? to seperate our value and they are reffers to as a delimiter
                    //In oneColumn we seperate our data with (',') so we put (',') in delimiter
                    {
                        columncounter++;
                        Console.WriteLine($"Column {columncounter} contains the value {value}");
                    }
                    //read the next line in the file 
                    readline = reader.ReadLine();
                }
                Console.WriteLine($"\n You read {records} records.\n");
            }
            catch (Exception ex)
            {
                //display a message indicating the problem
                Console.WriteLine($"\nYou had a problem reading the file. \n\nError: \t{ex.Message}\n");
            }
            finally
            {
                //due to the fact that we are reading a file
                //the file must be closed when you have finished reading all that you desire
                reader.Close();
            }
        }

        static string MenuPropmt()
        {
            string inputTempLocal = "";
            Console.WriteLine("File I/O options:");
            Console.WriteLine("a) Hard-coded file name.");
            Console.WriteLine("b) Using Windows Environment (Desktop, Documents, Download) path file name.");
            Console.WriteLine("c) Writing to a file.");
            Console.WriteLine("x) Exit.\n");
            Console.Write("Enter the menu option for File I/O:\t");
            inputTempLocal = Console.ReadLine();
            return inputTempLocal;
        }

        static void WriteToFile()
        {
            string PathName = @"D:\\GitHub\\CPSC-1012\\FileProcessing\\";
            string FullPathName = PathName + @"NewFile.txt";
            // declare "pipeline" variable to the output file
            StreamWriter writer;

            // create the pipeline:
            //  a) the file path name
            //  b) a true or false indicating the type of appending
            //      true: append to an existing the file or create the file if it does not exist
            //      false: recreate the file as a new file (overwrite of existing file if the file exists)

            try  //user freindly error handling
            {
                writer = new StreamWriter(FullPathName, false);
                Random rnd = new Random(); //setting up the random number generater variable
                int linesout = rnd.Next(1, 6); //desire numbers 1 through 5
                for (int looper = 0; looper < linesout; looper++) //fixed number of iterations
                {
                    //writing a line to your file
                    //NOTE: Remember to put the \n at the end of the string to force the next line in the file 
                    writer.Write($"line {looper}, Don\n");
                }
                //remember to close the file when you are finished 
                writer.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}\n\n");
            }
        }




    }
}

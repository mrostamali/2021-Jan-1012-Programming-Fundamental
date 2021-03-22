using System; //indicating a namespace

namespace IntroToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a variable 
            //datatype and name
            //optionally you can assign a value to the variable as it is created.
            //string inputTemp = null;

            //What about developer defined datatypes
            //The class name is used as the datatype 
            //
            //declaring a variable of the developer datatype class sets aside a physial are 
            //   in memory to hold the address location of the actual instance of the class
            //Default of these variables is null
            Wallet myWallet = null;

            //how does one get an instance (occurance) of my class
            //The instance is refferred to as the object
            //The instance is the physical thing
            //The NEW command executed the constructor of your class

            //signature of the Default constructor:

            myWallet = new Wallet();  

            Console.WriteLine($" Cash {myWallet.CashBills + myWallet.CashCoins}");

            Wallet herWallet = new Wallet();

            Console.WriteLine($" Cash {herWallet.CashBills + herWallet.CashCoins}");

            //signature of the Greedy constructor:

            Wallet hisWallet = new Wallet(10, 2, "ADDR1234", null, null, null);

            Console.WriteLine($" Cash {hisWallet.CashBills + hisWallet.CashCoins}");

            //assigning a value to my instance using the property 
            //the instance is on the left side of an assignment statement
            //the property is using the "set"
            myWallet.CashCoins = 13;
            //Console.WriteLine($" Cash {myWallet.CashBills + myWallet.CashCoins}");

            //access to the instance is using properties
            //the instance is on the right side of an assignment statement
            //property is using the "get"
            double addedNumbers = myWallet.CashBills + myWallet.CashCoins;
            Console.WriteLine($" Cash {addedNumbers}");
        }
    }
}

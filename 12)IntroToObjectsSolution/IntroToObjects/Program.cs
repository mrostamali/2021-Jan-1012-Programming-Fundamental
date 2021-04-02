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
            //declaring a variable of the developer datatype class sets aside a physial area 
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

            //changing a value in an existing instance 
            //since the property is on the left side of the assignmet statement
            //   the property mutator (set{..}) will be executed
            herWallet.CashCoins = 3.75;

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


            //object initializers
            //will use the default constructor to create the instance
            //THEN it assigns value to the data storage in the instance via a coding block
            //could also be new Wallet()  {....}
            Wallet myInitializedWallet = new Wallet
            {
                //BankCard = null, //null is a default value for a string
                CashBills = 25.00, //using the set of the property CahBills
                CashCoins = 2.00,
                GasCard = "123456"
            };

            Console.WriteLine($"cash {myInitializedWallet.CashBills + myInitializedWallet.CashCoins}");

            Console.WriteLine($"Cards Bank: {myInitializedWallet.BankCard},\t Gas: {myInitializedWallet.GasCard},\t Visa: {myInitializedWallet.VisaCard}");


            //using the class behavior (aka: method)
            //the method returns a bool (true or false)
            //REMEMBER, your condition resolve to either true or false 
            //  true == true resolves to true, WHY code the condition?  It means no need to code like this (herWallet.ExtractAmount(4.25) == true)
            //  false == true resolves to false, WHY code the condition?
            double insufficient = 4.25;
            double sufficient = 2.75;
            if (herWallet.ExtractAmount(sufficient))  
            {
                Console.WriteLine($"Sufficient coins, new coin amount: {herWallet.CashCoins}");
            }
            else
            {
                Console.WriteLine($"Insufficient coins, new coin amount: {herWallet.CashCoins}. Use bills and get your change back.");
            }


        }
    }
}

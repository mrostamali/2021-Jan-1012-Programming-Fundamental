using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToObjects
{
    //public access allows outside users access to the class
    //Who is the "outside" user?
    //  The outside user is anything NOT in the class
    public class Wallet
    {
        #region Data Members
        //data members 
        //  a data member is a piece of data 
        //  the data needs to be a valid datatype 
        //  Typically, these variables are private to the class
        private double _CashBills;
        private double _CashCoins;
        private string _DriverLicense;
        private string _BankCard;
        #endregion

        #region Properties
        //Properties
        // Each data member that you wish to expose to the outside user will typically has its OWN property     
        // Each property is public
        // Each property has the option of 
        //     a) reading the private data member (get)
        //     b) assigning a value to the private data member (set)
        //        is the likely option that an outside user does not has access to
        //
        //Syntax:
        // For fully Implemented Property
        // When to use:
        //      a) If you plan on saving the data to your own private data member 
        //      b) If you have to do ANY program before returning the private data member to the other user
        //      c) If you have to do ANY programing before assigning the incoming data to your private data member (validation)
        //    public datatype propertyname
        //    {
        //        get {....}  also known as accessor
        //        [set {.....}]   also known as mutator
        //              on the set, your incoming data is referenced using the keyword: value
        //    }
        public string DriverLicense
        {
            get { return _DriverLicense; }
            set { _DriverLicense = value; }
        }
        // For an auto Implemented Property
        // When to use:
        //   If there is NO additional processing needed for the data coming in or going out.
        //
        //   NOTE: when you use auto implemented properties you DO NOT create your OWN private data member
        //         instead, the system, ON YOUR BEHALF, will create a storage area for the data, will put 
        //         the value in this area for you, will retreive the data for you.
        //
        // Syntax:
        //    public datatype propertyname {get; set}

        //Auto Implemented Property examples
        public string GasCard { get; set; }
        public string VisaCard { get; set; }


        //Fully Implemented Property examples
        public double CashBills
        {
            //accessor
            get { return _CashBills; }
            //mutator
            set { _CashBills += value; }
        }

        public double CashCoins
        {
            get { return _CashCoins; }
            set { _CashCoins += value; }
        }

        public string BankCard
        {
            get { return _BankCard; }
            set { _BankCard = string.IsNullOrEmpty(value) ? null : value ; }
        }

        #endregion

        #region Constructor
        //Constructor 
        //Rule number 1: --IF, your class definition does not have a coded constructor 
        //               then the system will default ALL data member AND auto implemented 
        //               properties to the natural default value of the data variables's datatype:
        //               numerics: 0, strings: null, bool: false, and so on
        //
        //               --IF, you wish to assign non default system values to your data members
        //               AND/OR the auto implemented properties WHEN the instance of the class
        //               is created in your program then you must code your own constructor
        //
        //Rule number 2: IF, you HAVE/WANT to have multiple contructor, then you are responsible 
        //               for coding EACH AND EVERY constructor.

        //Purpose of the Constructor
        //  Assign value to the data member(s) and/or auto implemented properties

        //Syntax
        //  public Classname([lists of parameters]) { ..... }

        //Important points
        //    NOTE there is NO datatype between public and Classname
        //    That is beacuase there is no return datatype specified 
        //    NOTE the name of this structure is the same as the class name 

        //Examples
        //  "Default constructor"
        // How can I Recognize this constructor:
        // It has no parameter list
        //So the default constroctor can simply have nothing in it
        public Wallet()
        {
            //IF there is no code within the constructor, the variables of the class
            //   are assign the system default values for their datatype 

            //YOU COULD, assign your own values in this constructor
            //WE can say I want to give a wallet to everyone that has 5 dollar in it

            //HOW to assign a value
            //
            //  a) you could use the property (instructor's preference)
            // Auto implemented properteis are case a 
            CashBills = 5.00;   //Since one is placing a value INTO, then you are using SET
            //if it is indexer the laft hand side of the equal sign it is the set, otherwise it is a get
                              

            //  b) you could assing the value DIRECTLY to a private data member 
            //  WARNING! If your property does any logic against the value to be 
            //           assigned to the data member, this WILL NOT HAPPEN
            //  _CashBills = 5.00;
        }

        //NOTE: There is no return parameter so it is not a method 
        //It is not a property 

        //"Greedy" constructor
        //  It has a parameter list that generally has a parameter for EACH and EVERY
        //    data member/auto implemented property in the class
        public Wallet (int cashbills, int cashcoins, string driverlicense, string bankcard, string gascard, string visacard)
        {
            CashBills = cashbills;
            CashCoins = cashcoins;
            DriverLicense = driverlicense;
            BankCard = bankcard;
            GasCard = gascard;
            VisaCard = visacard;

        }
        //The purpuse of using a class is to make sure that when you create an instance  
        //  in your class it would be granteed that it is what called a null statements 
        #endregion

        #region Behaviours(aka Methods)
        //Behaviours generaly will be 
        //  a) actions not done in a property
        //  b) actions affecting multiple data members and/or auto implemented properties 

        //A good habit in coding your behaviours is to properties over data members
        public bool ExtractAmount (double amount)
        {
            bool Valid = false;
            if ((CashBills + CashCoins)  >= amount)
            {
                //logic to change cash bills and coins
                if(amount < 5.00)
                {
                    if(CashCoins > amount)
                    {
                        CashCoins = -amount;
                        Valid = true;
                    }
                }
                else
                {
                    if (CashBills > amount)
                    {
                        CashBills = -amount;
                        Valid = true;
                    }
                }
                //return true; instead of multiple return valu we should code like valid = true; :
                return Valid;
            }
            /* No need to have else here because we already assign false value to the Valid above
             else
             {
                 //return false;  BAD logic shouldnt have multiple return.
                 Valid = false;
             }
            */
            return Valid;
        }

        #endregion
    }
}

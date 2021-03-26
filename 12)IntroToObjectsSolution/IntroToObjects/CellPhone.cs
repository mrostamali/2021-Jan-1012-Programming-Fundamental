using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToObjects
{
    public class CellPhone
    {

        //Exercise:

        //Data Members:
        private double _ContactNumbers;
        private string _Banking;
        private string _Photos;
        private double _Musics;





        //Properrties: both Fully and Auto implemented properties
        //Fully implemented
        public double ContactNumbers
        {
            get { return _ContactNumbers; }
            set { _ContactNumbers += value; }
        }

        public double Musics
        {
            get { return _Musics; }
            set { _Musics += value; }
        }

        public string Photos
        {
            get { return _Photos; }
            set { _Photos += value; }
        }

        public string Banking
        {
            get { return _Banking; }
            set { _Banking = string.IsNullOrEmpty(value) ? null : value; }
        }

        //Auto implemented
        public string Gmail { get; set; }
        public string Notes { get; set; }
        public double Calendar { get; set; }







        //Constructors:
        //"Default constructor"
        public CellPhone()
        {
            Musics = 100;
        }

        //"Greedy" constructor
        public CellPhone(int contactnumbers, int musics, string banking, string photos, string gmail, string notes, double calendar)
        {
            ContactNumbers = contactnumbers;
            Banking = banking;
            Photos = photos;
            Musics = musics;
            Gmail = gmail;
            Notes = notes;
            Calendar = calendar;

        }





        //Behaviour
        public bool ChangeText(string text)
        {
            bool Valid = false;
            if (text.Length > 0)
            {
                if (text.Length < 40)
                {
                    Notes += text;
                }
                else
                {
                    Gmail += text;
                }
                Valid = true;
            }
            return Valid;
        }





    }
}

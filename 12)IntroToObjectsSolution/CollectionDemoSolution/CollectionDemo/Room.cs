using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{

    //Composite Class
    //   a composite class contains refrences to other classes
    //   the refrence may be a sinle instance or within a List<T>
    // we can have both private or public property in a composite class 
    public class Room
    {
        //data members are simply fields to hold data
        private string _Color; 
        private List<Opening> _Openings;

        public string Name { get; set; }

        //public string Color { get; set; }   //Or a fully implemented property as follow:
        public string Color
        {
            //accessor
            get { return _Color; }
            //the keyword value in this example is a datatype of string
            //the mutator validation does a default setting
            set { _Color = string.IsNullOrEmpty(value) ? "White" : value; }
        }


        public List<Wall> Walls { get; set; }
        //public List<Opening> Openings { get; set; }

        public List<Opening> Openings 
        {
            //accessor
            get { return _Openings; }
            set 
            {
                //the keyword value in this example is a datatype of List<T> (value is a List in here)
                if(value.Count == 0)
                {
                    //the mutator validation throws an error
                    throw new Exception("Your room needs at leat one openings.");
                }
                else
                {
                    _Openings = value;
                }
            } 
        }


        //NOTE: no constructors were created for this class.
        //when an instance of this class is created, the system will use the "system default constructor"
    }
}

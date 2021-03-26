using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{

    //Composite Class
    //   a composite class contains refrences to other classes
    //   the refrence may be a sinle instance or within a List<T>
    public class Room
    {
        private string _Color;  // we can have both private or public property in a composite class 

        public string Name { get; set; }

        //public string Color { get; set; }   //Or a fully implemented property as follow:

        public string Color
        {
            get { return _Color; }
            set { _Color = string.IsNullOrEmpty(value) ? "White" : value; }
        }

        public List<Wall> Walls { get; set; }
        public List<Opening> Openings { get; set; }
    }
}

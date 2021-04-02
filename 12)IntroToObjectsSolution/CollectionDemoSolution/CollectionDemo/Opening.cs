using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    public class Opening
    {
        //private members
        private double _Width;
        private double _Height;

        //properties
        //fully implemented property 
        public double Width
        {
            //accessor
            get { return _Width; }
            //mutator
            set { _Width = value > 0 ? value : throw new Exception("Width is invalid"); }
        }

        public double Height
        {
            //accessor
            get { return _Height; }
            //mutator
            set { _Height = value > 0 ? value : throw new Exception("Height is invalid"); }
        }


        //auto implemented property
        public string Description { get; set; }


        //constructor:
        //1)default
        public Opening()
        {
            Width = 3.0;
            Height = 2.5;
        }
        //2)Greedy
        public Opening(double width, double height, string description)
        {
            Width = width;
            Height = height;
            Description = description;
        }

        //behaviour (aks method)
        public double OpeningArea()
        {
            //Note: no parameters were set up
            //WHY?
            //  The method cabn access the sata within the instance
            //  by using either the properties or the private data member
            //GOOD RULE OF THUMB: properties over data members
            return Width * Height;
        }
    }
}

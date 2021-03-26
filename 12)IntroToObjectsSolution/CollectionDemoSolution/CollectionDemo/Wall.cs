using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    public class Wall
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

        //constructor:

        //1)default
        public Wall()
        {
            Width = 10.0;
            Height = 8.0;
        }
        //2)Greedy
        public Wall (double width, double height)
        {
            Width = width;
            Height = height;
        }

        //behaviour (aks method)
        public double WallArea()
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

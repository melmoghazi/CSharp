﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAttributes
{
    [DeBugInfo(45, "A Ali", "12/8/2012", Message = "Return type mismatch")]
    [DeBugInfo(49, "B Ali", "10/10/2012", Message = "Unused variable")]
    public class Rectangle
    {
        //member variables
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        [DeBugInfo(55, "C Ali", "19/10/2012", Message = "Return type mismatch")]
        public double GetArea()
        {
            return length * width;
        }

        [DeBugInfo(56, "D Ali", "19/10/2012")]
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}

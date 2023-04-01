﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    internal class Complex
    {
        private int real;
        private int img;
        public Complex(int r = 0, int i = 0)
        {
            real = r;
            img = i;
        }
        // + Operator overloading
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex temp = new Complex();
            temp.real = c1.real + c2.real;
            temp.img = c1.img + c2.img;
            return temp;
        }
        public void Display()
        {
            Console.WriteLine($"{real} + i{img}");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class MaximumInteger
    {
        public static int FindMaxInteger(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num2.CompareTo(num3) > 0 ||
                num1.CompareTo(num2) >= 0 && num2.CompareTo(num3) > 0 ||
                num1.CompareTo(num2) > 0 && num2.CompareTo(num3) >= 0)
            {
                return num1;

            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 ||
                num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 ||
                num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
            {
                return num2;
            }

            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num1) > 0 ||
                num3.CompareTo(num1) >= 0 && num3.CompareTo(num1) > 0 ||
                num3.CompareTo(num1) > 0 && num3.CompareTo(num1) >= 0)
            {
                return num3;
            }
            return num1;
        }
    }
}

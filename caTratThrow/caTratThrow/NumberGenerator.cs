﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caTratThrow
{
    internal class NumberGenerator
    {
        int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        public int GetNumber(int index)
        {
            if(index < 0 || index >= numbers.Length)
                // throw new ArgumentOutOfRangeException("index");
                throw new System.Exception("index");
            return numbers[index];
        }
    }
}

﻿using System;

namespace DynamicArray
{
    public class Program
    {
        static void Main()
        {
            DynamicNumberArray _dynamic = new DynamicNumberArray();
            _dynamic[0] = 10;
            _dynamic[1] = 20;
            _dynamic[2] = 30;
            _dynamic[3] = 40;
            _dynamic[4] = 50;
            _dynamic[5] = 60;

            int value = _dynamic[5];
            Console.WriteLine(value);
        }
    }
}
    


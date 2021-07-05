using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicArray
{
    public class DynamicNumberArray
    {

        int[] buffer;
        public DynamicNumberArray()
        {
            buffer = new int[5];

        }
        public DynamicNumberArray(int initialSize) { buffer = new int[initialSize]; }
        public int this[int index]
        {
            set
            {
                if (index >= buffer.Length)
                {
                    Array.Resize(ref buffer, index + 2);
                }

                buffer[index] = value;
            }
            get
            {
                return buffer[index];
            }
        }
    }
}

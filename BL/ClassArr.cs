using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClassArr
    {
        public int[] Arr { get; set; }

        public ClassArr(int[] arr)
        {
            this.Arr = arr;
        }

        public int Sum()
        {
            int s = 0;
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                s += Arr[i] * Arr[i + 1];
            }
            return s;
        }

        public int NegativeNumber()
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if ((i % 2 == 1) && (Arr[i] < 0))
                    return i;

            }
            return -1;
        }
    }
}

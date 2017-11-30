using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClassCycle
    {
        public double X { get; set; }

        public ClassCycle(double x)
        {
            this.X = x;
        }

        public double LeftCalculate()
        {
            return Math.Sin(X) / X;
        }

        public double RightCalculateSum( double e)
        {
            double sum = 1;
            double a = 1;
          
            int i = 1;
        
            while (Math.Abs(a)>e)
            {
                a *= -1*((double)(X * X) / ((2 * i) * (2 * i + 1)));
                sum += a;
                i++;
                
            }

            return sum;
        }

        public double RightCalculateCount(double e)
        {
           
            double a = 1;
            int n = 0;
            int i = 1;

            while (Math.Abs(a) > e)
            {
               
                a *= -1 * ((double)(X * X) / ((2 * i) * (2 * i + 1)));
                i++;
                n++;
            }

            return n;
        }


    }
}

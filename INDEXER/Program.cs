using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDEXER
{
    class Program
    {
        static void Main(string[] args)
        {
            number salem = new number(3); // 3 is value for n
            salem[0] = 3.2;
            salem[1] = 5.8;   // here we use SET in indexer
            salem[2] = 4.7;
            for (int i = 0; i < number.n; i++)
            {
                Console.WriteLine(salem[i]);
            }
        }
    }
    class number
    {
        double[] x = new double[n];
        static public int n;
        public number(int n)
        {
            for (int i = 0; i < n; i++)
            {
                x[i] = 0;  // initial value for array 
            }
        }

        public double this[int i]   // double here depends on array data type && "this" is a key word
        {
            get
            {
                double v;
                if(i>=0 && i < n)
                {
                    v = x[i];
                }else
                {
                    v = 0;
                }
                return v;
            }
            set
            {
                if (i>=0 && i < n)
                {
                    x[i] = value;
                }

            }
        }
    }
}

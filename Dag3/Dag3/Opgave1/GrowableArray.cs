using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    class GrowableArray
    {
        static void Main(string[] args)
        {
            GrowableArray g = new GrowableArray();
            g[0] = 7;
            g[1] = 9;
            g[2] = 13;
            Console.WriteLine(g[2]);
            Console.ReadLine();
        }

        public GrowableArray()
        {
            this.arr = new int[16];
        }

        public int[] arr;

        public int this[int i]
        {
            get
            {
                if (i > arr.Length - 1 || i < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return arr[i];
                }
            }

            set
            {
                if (i < 0)
                {
                    throw new IndexOutOfRangeException();
                } else if (i > arr.Length - 1) {
                    int[] temp = new int[this.arr.Length * 2];
                    Array.Copy(this.arr, temp, this.arr.Length);
                    this.arr = temp;
                }
                else
                {
                    arr[i] = value;
                }
            }
        }
    }
}

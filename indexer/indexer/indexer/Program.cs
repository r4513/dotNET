using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace indexer
{

    public struct Vector
    {
        private double x, y, z;

        public Vector(int x, int y, int z)
        {
            this.x = x; this.y = y; this.z = z;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double this[int i]
        {
            get
            {
                switch (i)
                {
                    case 1: return x;
                    case 2: return y;
                    case 3: return z;
                    default:
                        throw new IndexOutOfRangeException("get Vector " + i);
                }
            }

            set
            {
                switch (i)
                {
                    case 1: x = value; break;
                    case 2: y = value; break;
                    case 3: z = value; break;
                    default:
                        throw new IndexOutOfRangeException("set Vector " + i);
                }
            }
        }

        public double this[char i]
        {
            get
            {
                switch (i)
                {
                    case 'x': return x;
                    case 'y': return y;
                    case 'z': return z;
                    default:
                        throw new IndexOutOfRangeException("get Vector " + i);
                }
            }

            set
            {
                switch (i)
                {
                    case 'x': x = value; break;
                    case 'y': y = value; break;
                    case 'z': z = value; break;
                    default:
                        throw new IndexOutOfRangeException("set Vector " + i);
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector(7, 9, 13);

            Console.WriteLine(v[1] + " " + v[2] + " " + v[3]);
            v[2] = 100;
            Console.WriteLine(v[1] + " " + v[2] + " " + v[3]);
            v['z'] = 200;
            Console.WriteLine(v['x'] + " " + v['y'] + " " + v['z']);

            Console.ReadLine();
        }
    }

}

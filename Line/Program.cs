using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.Oom
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[] ks = new double[] { 1, 2, 3, 4 };
                double[] ls = new double[] { 5, 3, 4, 5 };

                Intersection(ks[0], ls[0], ks[3], ls[3]);
                Intersection(ks[1], ls[1], ks[2], ls[2]);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry");
            }
        }

        private static void Intersection(double k1, double l1, double k2, double l2)
        {
            if (k1 == k2)
                Console.WriteLine("Lines are paralel");
            else
            {
                double x = (l2 - l1) / (k1 - k2);
                double y = k1 * x + l1;
                Console.WriteLine($"Intersection: ({x}, {y})");
            }
        }
    }
}

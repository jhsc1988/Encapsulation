using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var line1 = new Line(1, 2);
            var line2 = new Line(2, 2);

            var intersection = line1.Intersection(line2);
            if(intersection == null)
                Console.WriteLine("Lines are parallel");
            else
            {
                Point p = intersection.Value;
                Console.WriteLine($"Intersection: ({p.X}, {p.Y})");
            }
        }
    }
}

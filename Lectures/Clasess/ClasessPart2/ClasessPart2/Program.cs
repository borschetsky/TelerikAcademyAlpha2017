using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Point3D two = new Point3D(2, 2, 2);
            var dist = Distance.DistanceBetweenTwoPoints(Point3D.O, two);
            Console.WriteLine(dist);

            Path path = new Path();
            path.SavePoints(Point3D.O);
            path.SavePoints(two);
            var pt = new Path();
            string res = path.ToString();
        }   
    }
}

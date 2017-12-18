using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessPart2
{
    public static class Distance
    {
        public static double DistanceBetweenTwoPoints(Point3D one, Point3D two)
        {
            //double[] pointsOne = new double[] {one.X, one.Y, one.Z };
            //double[] pointsTwo = new double[] { two.X, two.Y, two.Z }; 
            return Math.Sqrt(Math.Pow(two.X - one.X, 2) + Math.Pow(two.Y - one.Y, 2)
                + Math.Pow(two.Z - one.Z, 2)); ;
        }
    }
}
//float distance=(float) 
//Math.Sqrt(Math.Pow(point1[0]-point2[0],2) + Math.Pow(point1[1]-point2[1],2) + Math.Pow(point1[2]-point2[2],2))
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessPart2
{
    public struct Point3D
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);
        //Constr
        public Point3D(Double x, Double y, Double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        //Prop
        public Double X { get; set; }
        public Double Y { get; set; }
        public Double Z { get; set; }
        //
        public static Point3D O 
        {
            get {return o; } 
        }

        public override string ToString()
        {
            return $"Point X: {this.X:F2}\nPoint y: {this.Y:F2}\nPoint Z: {this.Z:F2}";
        }

    }
}

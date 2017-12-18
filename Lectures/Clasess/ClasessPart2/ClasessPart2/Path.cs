using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessPart2
{
    public class Path
    {
        private List<Point3D> somePoints;
        //const
        public Path()
        {
            somePoints = new List<Point3D>();
        }
        public Path(List<Point3D> somePoints) : this()
        {
            this.somePoints = somePoints;
        }
        //Prop
        public List<Point3D> SomePoint
        {
            get { return this.somePoints; }
            
        }

        public void SavePoints(Point3D currPoint)
        {
            somePoints.Add(currPoint);
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            foreach (Point3D item in this.somePoints)
            {
                res.Append(item.ToString());
            }
            res.Append("\n");
            return res.ToString();
        }
    }
}

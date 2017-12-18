using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Display
    {
        //Fields:
        private double? size;
        private int? numberOfColors;
        //Constructor

        public Display()
        {

        }
        public Display(double size)
        {
            this.Size = size;
        }
        public Display(double size, int numberOfColors) : this(size)
        {
            this.NumberOfColors = numberOfColors;
        }
        //Prop
        public double? Size
        {
            get {return size; }
            set {size = value; }
        }
        public int? NumberOfColors
        {
            get { return numberOfColors; }
            set { numberOfColors = value; }
        }
    }
}

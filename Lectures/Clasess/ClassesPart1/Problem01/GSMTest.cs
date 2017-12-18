using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class GSMTest
    {
        //Field
        private GSM[] arr;
        //Constr
        public GSMTest(GSM[] arr)
        {
            this.Arr = arr;
        }
        //
        public GSM[] Arr
        {
            get {return this.arr; }
            set {arr = value; }
        }

        public override string ToString()
        {
            StringBuilder finalResult = new StringBuilder();

            foreach (GSM item in this.arr)
            {
                finalResult.Append(item.ToString());
            }
            finalResult.Append(GSM.Iphone4);
            return finalResult.ToString();
        }
        //public GSMTest(params GSM[] arr)
        //{
        //    this.arr = arr;
        //}

        //public GSM[] Arr
        //{
        //    get { return this.arr; }

        //}

        //public override string ToString()
        //{
        //    StringBuilder finalResult = new StringBuilder();
        //    foreach (GSM item in this.Arr)
        //    {
        //        finalResult.Append(item.ToString());
        //    }
        //    finalResult.Append(GSM.Iphone4);
        //    return finalResult.ToString();
        //}
    }
}

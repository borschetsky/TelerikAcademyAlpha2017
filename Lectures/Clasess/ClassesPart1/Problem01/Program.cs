using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Problem01
{
    class Program
    {

        static void Main(string[] args)
        {
            //Phones
            GSM newPhone = new GSM("iPhoneX", "Apple Inc.");
            GSM newAndroid = new GSM("Galaxy S8", "Samsung", 2000, "Jobs");
            DateTime currentDate = new DateTime(2017, 12, 6);
            Call newCall = new Call(currentDate, "380935246428", 30);
            List<Call> lisCall = new List<Call>()
            {
                new Call(new DateTime(2017, 12, 10), "+380931231233", 100),
                new Call(new DateTime(2015, 10, 10), "+380935246428", 150),
                new Call(new DateTime(2017, 10, 10), "+380931234567", 200)

            };
            GSM newiPhoneX =
                new GSM("iPhone X", "Apple Inc.", 2000, "Borwchetsy",
                new Battery("China", 10.00, 20.00, 10.00, BatteryType.Li_On),
                new Display(8.4, 4), lisCall);

            Battery btr = new Battery();
            GSM[] arrray = new GSM[] { newPhone, newAndroid, newiPhoneX };
            GSMTest newTest = new GSMTest(arrray);
            GSMCallHistoryTest.TotalPrice();
            decimal? sumOfcallDur = (newiPhoneX.CallHistory.Select(call => call.Duration).Sum() / (decimal)60) * 0.37m;
            Console.WriteLine(sumOfcallDur);
            newiPhoneX.CallHistory.Remov
            //Console.WriteLine(newiPhoneX.CallPrice(0.37m));
            //Console.WriteLine(newPhone.ToString());
            //Console.WriteLine(newiPhoneX.ToString());
        }
        


            

        


    }
}
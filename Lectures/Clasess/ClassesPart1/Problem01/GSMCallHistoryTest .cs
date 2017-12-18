using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class GSMCallHistoryTest
    {
        
        public static List<Call> CreateCalls()
        {
            
            List<Call> lisCall = new List<Call>()
            {
                new Call(new DateTime(2017, 12, 10), "+380931231233", 100),
                new Call(new DateTime(2015, 10, 10), "+380935246428", 150),
                new Call(new DateTime(2017, 10, 10), "+380931234567", 200)

            };
            var GSM = new GSM("iPhone", "Apple Inc.", lisCall);
            
            return lisCall;
        }
        public static void PrintCalls()
        {
            var list = CreateCalls();
            foreach (var item in list)
            {
                Console.WriteLine($"Date: {item.Date}\n{item.PhoneNumber}\n{item.Duration}");
            }
        }
        public static void TotalPrice()
        {
            var list = CreateCalls();
            int? sum = 0;
            foreach (var item in list)
            {
                sum += item.Duration;
            }
            double? newSum = sum / 60 * 0.37;
            Console.WriteLine(newSum);
        }
        
    }
}

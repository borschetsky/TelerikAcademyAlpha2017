using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem01
{
    class Call
    {
        //Field
        private DateTime date;
        private string phoneNumber;
        private int? duration;
        //Constructor
        public Call(DateTime date)
        {
            this.Date = date;
        }
        public Call(DateTime date, string phoneNumber) : this(date)
        {
            this.PhoneNumber = phoneNumber;
        }
        public Call(DateTime date, string phoneNumber, int duration) : this(date, phoneNumber)
        {
            this.Duration = duration;
        }
        //Prop
        public DateTime Date
        {
            get {return this.date; }
            set
            {
                if (value.Year < 2000 || value.Year > 2017 || value.Month < 1 || value.Month > 12 || value.Day < 1 || value.Day > 31)
                    throw new ArgumentException("Wrong date");
                else
                    this.date = value;
            }
        }
        public string PhoneNumber
        {
            get {return this.phoneNumber; }
            set {this.phoneNumber = value; }
        }
        public int? Duration
        {
            get {return this.duration; }
            set { this.duration = value; }
        }
        //Method
        public override string ToString()
        {
            StringBuilder callHistory = new StringBuilder();
            callHistory.Append($"Date: {date.Day:D2}:{date.Month:D2}:{date.Year}\n");
            //Phone Number
            if(phoneNumber != null)
                callHistory.Append($"Phone number: {phoneNumber}\n");
            else
                callHistory.Append($"Phone number: No info!\n");
            //Duration
            if (duration != null)
                callHistory.Append($"Duration: {duration}\n");
            else
                callHistory.Append("Call History: No info!\n");

            return callHistory.ToString();
        }
    }
}

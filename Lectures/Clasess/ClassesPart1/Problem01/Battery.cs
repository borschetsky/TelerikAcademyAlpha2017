using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Battery
    {
        //Fields:
        private string model;
        private double? hours;
        private double? idle;
        private double? hoursTalk;
        private BatteryType? batteryType;
        //Constructor:

        public Battery()
        {
            
        }
        public Battery(string model)
        {
            this.Model = model;
        }
        public Battery(string model, double hours) : this(model)
        {
            this.Hours = hours;
        }
        public Battery(string model, double hours, double idle) : this(model, hours)
        {
            this.Idle = idle;
        }
        public Battery(string model, double hours, double idle, double hoursTalk) : this(model, hours, idle)
        {
            this.HoursTalk = hoursTalk;
        }
        public Battery(string model, double hours, double idle, double hoursTalk, BatteryType batteryType) : this(model, hours, idle, hoursTalk)
        {
            this.BatteryType = batteryType;
        }
        //Property
        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }
        public double? Hours
        {
            get {return hours; }
            set {hours = value; }
        }
        public double? Idle
        {
            get {return idle; }
            set {idle = value; }
        }
        public double? HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }
        public BatteryType? BatteryType
        {
            get { return batteryType; }
            set { batteryType = value; }
        }
    }
}
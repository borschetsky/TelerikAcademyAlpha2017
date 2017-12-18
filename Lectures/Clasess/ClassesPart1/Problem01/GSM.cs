using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class GSM
    {
        //Fields:
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private static GSM iPhone4 = new GSM ("iPhone4S", "Apple Inc.");
        private Call call;
        private List<Call> callHistory;


        //Constructors:
        
        public GSM(string model, string manufacturer)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }
        public GSM(string model, string manufacturer, List<Call> callHistory) : this(model, manufacturer)
        {
            this.CallHistory = callHistory;
        }
        public GSM(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }
        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner, battery)
        {
            this.Display = display;
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display, Call call)
            : this(model, manufacturer, price, owner, battery, display)
        {
            this.Call = call;
        }
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display, List<Call> callHistory)
            : this(model, manufacturer, price, owner, battery, display)
        {
            this.CallHistory = callHistory;
        }
        
        //Prop
        
        public string Model
        {
            get {return model; }
            set {model = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }
        public decimal? Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }
        public Display Display
        {
            get { return display; }
            set { display = value; }
        }
        public static GSM Iphone4
        {
            get { return iPhone4; }
             
        }
        public  Call Call
        {
            get { return call;}
            set {this.call = value; }


        }
        public List<Call> CallHistory
        {
            get {return this.callHistory; }
            set {this.callHistory = value; }
        }
        //Method
        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();
            //Mantadory params
            stb.Append($"Model: {this.Model}\nManufacturer: {this.Manufacturer}\n");
            //Optional---------------------------------
            //Price
            if (this.Price != null)
                stb.Append($"Price:{this.Price}\n");
            else
                stb.Append($"Price: No info!\n");
            //Owner
            if (this.Owner != null)
                stb.Append($"Owner:{this.Owner}\n");
            else
                stb.Append($"Owner: No info!\n");
            //Battery
            if (battery != null)
            {
                if (this.battery.Model != null)
                    stb.Append($"Battery Model: {this.Battery.Model}\n");
                else
                    stb.Append($"Battery Model: No info!\n");
                if (this.battery.Hours != null)
                    stb.Append($"Battery Hours: {this.Battery.Hours}\n");
                else
                    stb.Append($"Battery Hours: No info!\n");
                if (this.battery.Idle != null)
                    stb.Append($"Battery Idle: {this.Battery.Idle}\n");
                else
                    stb.Append($"Field is empty\n");
                if (this.battery.HoursTalk != null)
                    stb.Append($"Battery Hours Talk: {this.Battery.HoursTalk}\n");
                else
                    stb.Append($"Field is empty\n");
                if (battery.BatteryType != null)
                    stb.Append($"Battery Type: {this.battery.BatteryType}\n");
                else
                    stb.Append("Battery type: No info!\n");
            }
            else
                stb.Append($"Battery: No Battery Info!\n");
            //Display
            if (display != null)
            {
                if (display.Size != null)
                    stb.Append($"Display Size: {this.Display.Size}\n");
                else
                    stb.Append($"Field is empty\n");
                if (display.NumberOfColors != null)
                    stb.Append($"Display Number of Colors: {this.Display.NumberOfColors}\n");
                else
                    stb.Append($"Field is empty\n");

            }
            else
                stb.Append("Display: No Info!\n");
            //Call
            if (call != null)
            {
                if (call.Date != null)
                    stb.Append($"CallDate: {this.call.Date}\n");
                else
                    stb.Append($"CallDate: No Info!\n");
                if (call.Duration != null)
                    stb.Append($"CallDuration: {this.call.Duration}\n");
                else
                    stb.Append($"CallDuration: No Info!\n");
                if (call.PhoneNumber != null)
                    stb.Append($"PhoneNumber: {this.call.PhoneNumber}\n");
                else
                    stb.Append("Phone Number: No Info\n");
            }
            else
                stb.Append("No Call Info!");
            
            if (callHistory != null)
            {
                stb.Append("CallHistory:\n");
                foreach (Call item in callHistory)
                {
                    stb.Append($"{item}\n");
                }
            }
            else
                stb.Append("No CallHistory!");
            
            return stb.ToString();
            
        }
        public void AddCalls(Call currentCall)
        {
            callHistory.Add(currentCall);
        }
        public void ClearCallHistory()
        {
            callHistory.Clear();
        }
        public void RemoveCall()
        {
            CallHistory.Remove(this.callHistory[this.callHistory.Count - 1]);
        }
        public decimal? CallPrice(decimal pricePerMinute)
        {
            return (this.callHistory.Select(call => call.Duration).Sum() / (decimal)60) * pricePerMinute;
        }
        
      
    }
}

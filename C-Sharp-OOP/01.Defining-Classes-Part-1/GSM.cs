using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class GSM
    {
        private static GSM IPhone4S = new GSM("IPhone 4s", "Apple", 1000, "John", new Battery(BatteryType.LiIon, 300, 8), new Display(4.5, 16000000));

        //fields
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        //constructors
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<Call>();
        }

        //properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("The model name must start with upper char!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("The manufacturer name must start with upper char!");
                }
                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price can't be negative!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (char.IsLower(value[0]))
                {
                    throw new ArgumentException("The owner name must start with upper char!");
                }
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        //add IPhone to class GSM (static)
        public static GSM IPhone
        {
            get
            {
                return IPhone4S;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        //methods
        public void AddCalls(string dialled, double duration)
        {
            this.callHistory.Add(new Call(dialled, duration));
        }

        public void DeleteCalls(int index)
        {
            this.callHistory.RemoveAt(index);
        }

        public void ClearCalls()
        {
            this.callHistory.Clear();
        }

        public double CallPrice(double price)
        {
            double totalPrice = 0;
            foreach (var call in this.callHistory)
            {
                totalPrice += call.Duration;
            }

            return totalPrice * price;
        }

        public override string ToString() //print full information on the console
        {
            StringBuilder fullInformation = new StringBuilder();

            fullInformation.AppendLine("Model: " + this.Model);
            fullInformation.AppendLine("Manufacturer: " + this.Manufacturer);
            fullInformation.AppendLine("Price: " + this.Price + " US");
            fullInformation.AppendLine("Owner: " + this.Owner);
            fullInformation.AppendLine("Battery: " + this.Battery.Model);
            fullInformation.AppendLine("Battery hours idle: " + this.Battery.HoursIdle + " h");
            fullInformation.AppendLine("Battery hours talk: " + this.Battery.HoursTalk + " h");
            fullInformation.AppendLine("Display size: " + this.Display.Size + @"""");
            fullInformation.AppendLine("Display colors: " + this.Display.Colors);

            return fullInformation.ToString();
        }
    }
}

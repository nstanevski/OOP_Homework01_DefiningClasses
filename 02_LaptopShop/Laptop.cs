using System;
using System.Text;
using System.Collections.Generic;



namespace LaptopShop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram; //RAM in GB
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private double batteryLife; //in hours
        private decimal price; //in leva

        public Laptop(string model, decimal price, string manufacturer, string processor, int ram,
            string graphicsCard, string hdd, string screen, Battery battery, double batteryLife)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.BatteryLife = batteryLife;
            this.Price = price;
        }

        public Laptop(string model, decimal price)
            :this(model, price, null, null, 0, null, null, null, null, 0.0)
        {

        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Laptop model cannot be null or empty");
                this.model = value;
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
                if (value<0m || value > 4000m)
                    throw new ArgumentOutOfRangeException("Laptop price is a value in range [0..4000] lv.");
                this.price = value;
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
                if (value != null && value == "")
                    throw new ArgumentException("Manufacturer cannot be an empty string");
                this.manufacturer = value;
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value != null && value == "")
                    throw new ArgumentException("Processor cannot be an empty string");
                this.processor = value;
            }
        }

        public int Ram
        {
            get 
            {
                return this.ram;
            }
            set
            {

                if(value != 0 && (value<2 || value >64))
                    throw new ArgumentOutOfRangeException("Laptop RAM (if specified) is a value in range [2..64] GB.");
                this.ram = value;

            }
        }

        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value != null && value == "")
                    throw new ArgumentException("Graphics card cannot be an empty string");
                this.graphicsCard = value;
            }
        }

        public string Hdd
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value != null && value == "")
                    throw new ArgumentException("HDD cannot be an empty string");
                this.hdd = value;
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value != null && value == "")
                    throw new ArgumentException("Screen cannot be an empty string");
                this.screen = value;
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
                try
                {
                    this.battery = value;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                    throw ex;
                }
                
                    
            }
        }

        public double BatteryLife 
        { 
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Battery life is a value in range [0.0 ... 100.0] hours.");
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            List<string> itemsList = new List<string>();
            Dictionary<string, string> laptopProps = new Dictionary<string, string>();

            laptopProps.Add("Model", this.model);
            if (this.manufacturer != null)
                laptopProps.Add("Manufacturer", this.manufacturer);
            if (this.processor != null)
                laptopProps.Add("Processor", this.processor);
            if (this.ram >0)
                laptopProps.Add("RAM", string.Format("{0} GB", ram));
            if (this.graphicsCard != null)
                laptopProps.Add("Graphics card", this.graphicsCard);
            if (this.hdd != null)
                laptopProps.Add("HDD", this.hdd);
            if (this.screen != null)
                laptopProps.Add("Screen", this.screen);
            if (this.battery != null)
                laptopProps.Add("Battery", this.Battery.ToString());
            if (this.batteryLife > 0.0)
                laptopProps.Add("Battery life", string.Format("{0:f1} hours", this.batteryLife));
            laptopProps.Add("Price", string.Format("{0:F2} lv.", this.price));

            foreach (KeyValuePair<string, string> kvp in laptopProps)
                itemsList.Add(string.Format("{0}: {1}", kvp.Key, kvp.Value));

            return string.Join("\n", itemsList);
        }    
    }
}

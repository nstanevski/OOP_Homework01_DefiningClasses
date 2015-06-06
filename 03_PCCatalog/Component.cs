using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace PCCatalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public Component(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(string name, decimal price)
            :this(name, null, price)
        {

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("name cannot be null or empty");
                this.name = value;
            }
        }

        public string Details { get; set; }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0m || value > 4000m)
                    throw new ArgumentOutOfRangeException("Computer price is a value in range [0..4000] lv.");
                this.price = value;
            }

        }

        public override string ToString()
        {
            CultureInfo bg = new CultureInfo("bg-BG");
            return string.Format("{0}: {1}", this.Name, this.Price.ToString("c", bg));
        }
    }
}

using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;


namespace PCCatalog
{
    class Computer
    {
        private string name;
        private List<Component> components;

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            if (components == null)
                components = new List<Component>();
            this.Components = components;
        }

        public Computer(string name):this(name, null)
        {

        }

     
        public string  Name 
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

        //price is dynamic property:
        public decimal Price 
        { 
            get
            {
                if (this.components == null)
                    return 0.0m;

                decimal result = 0.0m;

                foreach (Component component in components)
                {
                    result += component.Price;
                }
                return result;
            }
        }

        public List<Component> Components
        {
            get
            {
                return this.components;
            }
            set
            {
                this.components = value;
            }
        }

        //public void AddComponent(Component component)
        //{
        //    if (this.components == null)
        //        this.components = new List<Component>();
        //    this.Components.Add(component);
        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            CultureInfo bg = new CultureInfo("bg-BG");
            sb.Append("Computer Name: " + this.Name+'\n');
            if (Components != null)
            {
                foreach (Component c in this.components)
                {
                    sb.Append(c.ToString() + '\n');
                }
            }
            
            sb.Append(string.Format("Total Computer Price: {0}", this.Price.ToString("c", bg)));
            return sb.ToString();
        }

    }
}

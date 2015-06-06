using System;
using System.Collections.Generic;
//using System.Linq;

namespace LaptopShop
{
    enum BatteryTypes {LiPol=1, LiIon, NiMH};

    class Battery
    {
        private BatteryTypes batteryType;
        private int numCells; //number of cells
        private int capacity; //capacity in mAh

        public Battery(BatteryTypes batteryType, int numCells, int capacity)
        {
            this.BatteryType = batteryType;
            this.NumCells = numCells;
            this.Capacity = capacity;
        }

        public Battery(BatteryTypes batteryType, int numCells)
            :this(batteryType, numCells, 0)
        {
        }

        public Battery(BatteryTypes batteryType)
            : this(batteryType, 0, 0)
        {
        }

        public Battery()
        {
        }

        public BatteryTypes BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                int enumLen = Enum.GetNames(typeof(BatteryTypes)).Length;
                if ( ((int)value < 1) || ((int)value > enumLen))
                {
                    string msg = string.Format("Battery type must be a value in range [1...{0}]", enumLen);
                    throw new ArgumentOutOfRangeException(msg);
                }                 
                this.batteryType = value;
            }
        }

        public int NumCells
        {
            get
            {
                return this.numCells;
            }
            set
            {
                if (value < 2 || value > 16)
                    throw new ArgumentOutOfRangeException("Battery cells value must be in range [2..16]");
                this.numCells = value;
            }
        }

        public int Capacity 
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value < 1000 || value > 5000)
                    throw new ArgumentOutOfRangeException("Battery capacity must be in range [1000..5000] mAh");
                this.capacity = value;
            }
        }

        public override string ToString()
        {
            List<string> specs = new List<string>();

            if ((int)this.batteryType > 0)
            {
                string[] batTypes = Enum.GetNames(typeof(BatteryTypes));
                specs.Add(batTypes[(int)this.batteryType - 1]);
            }

            if (this.numCells > 0)
            {
                specs.Add(this.numCells.ToString() + "-cells");
            }

            if (this.capacity > 0)
            {
                specs.Add(this.capacity.ToString() + " mAh");
            }

            return string.Join(", ", specs);
        }


    }
}

using System;
using System.Collections.Generic;

/*
 * Define a class Laptop that holds the following information about a laptop device: 
 * model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, 
 * battery life in hours and price.
 * The model and price are mandatory. All other values are optional.
 * Define two separate classes: a class Laptop holding an instance of class Battery.
 * Define several constructors that take different sets of arguments 
 * (full laptop + battery information or only part of it). Use proper variable types.
 * Add a method in the Laptop class that displays information about the given instance
 * Tip: override the ToString() method
 * Put validation in all property setters and constructors. 
 * String values cannot be empty, and numeric data cannot be negative. 
 * Throw exceptions when improper data is entered.
 */

namespace LaptopShop
{
    class LaptopShop
    {
        static void Main()
        {
            Laptop laptop1 = new Laptop("Lenovo B5400", 999.00m);
            Console.WriteLine(laptop1);
            Console.WriteLine("========");

            Battery bat = new Battery(BatteryTypes.LiIon, 8, 3600);
            laptop1.Battery = bat;
            Console.WriteLine(laptop1);
            Console.WriteLine("========");

            Laptop laptop2 = new Laptop("Lenovo Yoga 2 Pro",
                                        2200m,
                                        "Lenovo", 
                                        "Intel Core I5 -4210U (2-core, 1.70 - 2.70 GHz, 3MB cache,)",
                                        4, "Intel HD Graphics 4400",
                                        "128GB SSD",
                                        @"13.3 (33.78 cm) – 3200 x 1800 (QHD+) IPS sensor display",
                                        bat,
                                        4.5);

            Console.WriteLine(laptop2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Define a class Computer that holds name, several components and price. The components 
 * (processor, graphics card, motherboard, etc.) should be objects of class Component, 
 * which holds name, details (optional) and price. 
 * Define several constructors that take different sets of arguments. Use proper variable types. 
 * Use properties to validate the data. Throw exceptions when improper data is entered.
 * Add a method in the Computer class that displays the name, each of the components' 
 * name and price and the total computer price. 
 * The total price is the sum of all components' price. Print the prices in BGN currency format.
 * Create several Computer objects, sort them by price, and print them on the console 
 * using the created display method.
 */

namespace PCCatalog
{
    class PCCatalog
    {
        static void Main()
        {
            List<Computer> pcCatalog = new List<Computer>();

            Computer c1 = new Computer("Empty comp");
            Component motherboard = new Component("Motherboard", "MTB 202", 34.55m);
            Component videoCard = new Component("Video card", "VCD 302", 64.95m);
            c1.Components.Add(motherboard);
            c1.Components.Add(videoCard);
            pcCatalog.Add(c1);

            List<Component> components = new List<Component>();
            components.Add(new Component("Motherboard", "MTB 303", 34.55m));
            components.Add(new Component("Video card", "VCD 402", 64.95m));
            components.Add(new Component("RAM - 8GB", null, 54.95m));
            Computer c2 = new Computer("Second comp", components);
            pcCatalog.Add(c2);

            //computer with empty name is invaid:
            //Computer c3 = new Computer("");
            Computer c3 = new Computer("C3", null);
            List<Component> componentsC3 = new List<Component>();
            //component with null or empty name is invalid:
            //componentsC3.Add(new Component("", "MTB 303", 94.55m));
            //component with negative price is invalid
            //componentsC3.Add(new Component("Motherboard", "MTB 503", -5m));
            componentsC3.Add(new Component("Motherboard", "MTB 503", 94.55m));
            componentsC3.Add(new Component("Video card", "VCD 402", 64.95m));
            componentsC3.Add(new Component("RAM - 16GB", null, 154.25m));
            componentsC3.Add(new Component("Sound card", "Yamaha", 254.95m));
            c3.Components = componentsC3;
            pcCatalog.Add(c3);

            var computerQry =
            from computer in pcCatalog
            orderby computer.Price
            select computer;

            foreach (Computer computer in computerQry)
            {
                Console.WriteLine(computer);
                Console.WriteLine("------------------------------");
            }
        }
    }
}

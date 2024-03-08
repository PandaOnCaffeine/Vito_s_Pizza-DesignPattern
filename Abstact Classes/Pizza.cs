using System;
using System.Collections.Generic;

namespace Vito_s_Pizza_DesignPattern.Abstact_Classes
{
    internal abstract class Pizza
    {
        private string _name;
        private List<string> _toppings = new List<string>()
        {
            "Tomat",
            "Ost"
        };

        public Pizza(string name, List<string> toppings)
        {
            _name = name;
            foreach (string topping in toppings)
            {
                _toppings.Add(topping);
            }
        }

        public void Print()
        {
            Console.WriteLine("═════════════════════════════════");
            Console.WriteLine("Pizza Name: " + _name);
            Console.WriteLine("Toppings Name: \n");

            foreach (string topping in _toppings)
            {
                Console.WriteLine(topping);
            }
            Console.WriteLine("");
        }
    }
}

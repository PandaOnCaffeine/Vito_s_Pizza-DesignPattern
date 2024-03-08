using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vito_s_Pizza_DesignPattern.Abstact_Classes;

namespace Vito_s_Pizza_DesignPattern.Classes
{
    internal class PizzaFactory
    {
        private Random rng = new Random();
        public PizzaFactory() { }
        public Pizza CreatePizza()
        {
            int pizzaType = rng.Next(1, 4);

            switch (pizzaType)
            {
                case 1:
                    return new Anchovy("Anchovy", new List<string>() { "Rødløg / Red onion", "Basilikum", "Anjoser" }); // My Console apparently doesn't show Ø
                case 2:
                    return new Margarita("Margarita", new List<string>() { "Oregano" });
                case 3:
                    return new Vesuvio("Vesuvio", new List<string>() { "Æg", "Basilikum" });
                default:
                    return null;
            }
        }
    }
}

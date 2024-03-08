using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vito_s_Pizza_DesignPattern.Abstact_Classes;
using Vito_s_Pizza_DesignPattern.Classes;

namespace Vito_s_Pizza_DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> pizzas = new List<Pizza>();

            PizzaFactory pizzaFactory = new PizzaFactory();

            for (int i = 0; i < 25; i++)
            {
                pizzas.Add(pizzaFactory.CreatePizza());
            }

            foreach (Pizza pizza in pizzas)
            {
                pizza.Print();
            }

            Console.ReadLine();
        }
    }
}

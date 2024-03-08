using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vito_s_Pizza_DesignPattern.Abstact_Classes;

namespace Vito_s_Pizza_DesignPattern.Classes
{
    internal class Vesuvio : Pizza
    {
        public Vesuvio(string name, List<string> toppings) : base(name, toppings) { }
    }
}

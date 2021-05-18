using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    //Concret Component B
    public class DeluxeCar : ICar
    {
        public decimal GetCost()
        {
            return 80000;
        }

        public string GetDescription()
        {
            return "Carro de Luxo";
        }
    }
}

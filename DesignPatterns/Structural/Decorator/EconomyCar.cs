using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    //Concret Component A
    public class EconomyCar : ICar
    {
        public decimal GetCost()
        {
            return 39000;
        }

        public string GetDescription()
        {
            return "Carro Econômico";
        }
    }
}

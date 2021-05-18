using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    //Concret Decorator
    public class BasicAccessories : CarAccessoriesDecorator
    {
        public BasicAccessories(ICar car)
        : base(car)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " com acessórios básicos.";

        }

        public override decimal GetCost()
        {
            return base.GetCost() + 6000;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    /// <summary>   
    /// Concrete Decorator   
    /// </summary>   
    public class DeluxeAccessories : CarAccessoriesDecorator
    {
        public DeluxeAccessories(ICar aCar)
        : base(aCar)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " com acessórios de luxo.";
        }

        public override decimal GetCost()
        {
            return base.GetCost() + 15000;
        }
    }
}

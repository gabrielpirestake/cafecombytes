using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    //Component
    public interface ICar
    {
        string GetDescription();
        decimal GetCost();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    // Observer
    public interface IObserver
    {
        string Name { get; }
        void Notify(Investment investment);
    }
}

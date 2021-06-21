using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    // Concrete Observer
    internal class Observer : IObserver
    {
        public Observer(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Notify(Investment investment)
        {
            Console.WriteLine("Notificando {0} que {1} " +
                              "teve preço alterado para {2:C}", Name, investment.Symbol, investment.Value);
        }
    }
}

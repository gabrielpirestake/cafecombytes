using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract_Factory
{
    //Abstract Product
    public abstract class Vehicle
    {
        protected Vehicle(Size size)
        {
            Size = size;
        }

        public abstract void Transport(Dog dog);
        public Size Size { get; set; }
    }
}

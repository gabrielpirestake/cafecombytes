using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract_Factory
{
    //Abstract Factory
    public abstract class VeterinaryFactory
    {
        public abstract Dog CreateDog(string dogName, string dogBreed);

        public abstract Vehicle CreateVehicle();
    }
}

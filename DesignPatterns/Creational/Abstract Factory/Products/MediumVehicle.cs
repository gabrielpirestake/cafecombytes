using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract_Factory
{
    //Concret Product
    public class MediumVehicle : Vehicle
    {
        public MediumVehicle(Size size) : base(size)
        {

        }

        public override void Transport(Dog dog)
        {
            Console.WriteLine($"Atendendo o cachorro médio - Nome: {dog.Name} | Raça: {dog.Breed}");
        }
    }
}

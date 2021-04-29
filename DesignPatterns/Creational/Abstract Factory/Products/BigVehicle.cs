using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract_Factory
{
    //Concret Product
    public class BigVehicle : Vehicle
    {
        public BigVehicle(Size size) : base(size)
        {

        }

        public override void Transport(Dog dog)
        {
            Console.WriteLine($"Atendendo o cachorro grande - Nome: {dog.Name} | Raça: {dog.Breed}");
        }
    }
}

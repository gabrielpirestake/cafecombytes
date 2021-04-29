using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract_Factory
{
    //Concret Factory
    public class BigDogTransportFactory : VeterinaryFactory
    {
        public override Dog CreateDog(string dogName, string dogBreed)
        {            
            return new BigDog
            {
                Name = dogName,
                Breed = dogBreed,
            };
        }

        public override Vehicle CreateVehicle()
        {
            return new BigVehicle(Size.Big);
        }
    }
}

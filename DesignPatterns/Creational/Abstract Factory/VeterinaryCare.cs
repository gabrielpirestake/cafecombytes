using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Abstract_Factory
{
    // Client
    public class VeterinaryCare
    {
        private readonly Vehicle _vehicle;
        private readonly Dog _dog;       
        public VeterinaryCare(VeterinaryFactory hospitalFactory,
                              string dogName,
                              string dogBreed)
        {            
            _dog = hospitalFactory.CreateDog(dogName, dogBreed);
            _vehicle = hospitalFactory.CreateVehicle();
        }

        public void Attend()
        {
            _vehicle.Transport(_dog);
        }

        public static VeterinaryCare CreateTicket(Size size, string dogName, string dogBreed)
        {
            return size switch
            {
                Size.Medium => new VeterinaryCare(new MediumDogTransportFactory(), dogName, dogBreed),
                Size.Big => new VeterinaryCare(new BigDogTransportFactory(), dogName, dogBreed),
                _ => throw new ApplicationException("Tamanho não reconhecido pelo sistema."),
            };
        }
    }
}

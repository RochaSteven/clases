

using System;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleEmpresa
{
    class Empresa
    {
        readonly Random random = new Random();
      
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Propietario { get; set; }
        
    

        public Vehiculo ConstruirVehiculo(string modelo)
        {
            return new Vehiculo()
            {
                Id = random.Next(),
                Marca = Nombre,
                Modelo = modelo

            };
        }
        
       
        }

    
}

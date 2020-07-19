using System;

namespace ConsoleEmpresa
{
    class Cliente:Persona
    {
        
        
        public string Direccion { get; set; }
        public Cliente():base ()
        {
            Nombre = "Ligth";
            Apellido = "Yagamy";

        }
        

        private Vehiculo vehiculo;
        public Vehiculo Vehiculo 
        {
            get { return vehiculo; } 
            set 
            {
                vehiculo = value;
                vehiculo.Propietario = this;
            } }

      

        public string Comprar ()
        {
            return $"El cliente con el numero de cedeula: {Cedula}\n con el nombre y apellido: {Nombre} {Apellido}\n direccion: {Direccion}\n";
        }

        public string Mostrarvehiculo()
        {
            return $"Se compro el vehiculo {Vehiculo.Modelo}\n de la marca {Vehiculo.Marca}\n de color {Vehiculo.Color}";
        }
       
    }
}

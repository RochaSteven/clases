using System;

namespace ConsoleEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            var empresa = new Empresa();
            empresa.Id = new Random().Next();
            empresa.Nombre = "Chevrolet";
            empresa.Propietario = "Ing. Alex Paul";
            
            var cliente = new Cliente
            {
                Id = new Random().Next(),
                Cedula = "1734567890",
                Nombre = "Steven",
                Apellido = "Rocha",
                Direccion = "terminal quitumbe"
            };


            var carro = new Vehiculo
            {
                Id = new Random().Next(),
                Color = "rojo",
                Marca = "Chevrolet",
                
            };


            cliente.Vehiculo=carro;

            Motor motor = new Motor
            {
                Id = new Random().Next(),
                Marca = "Nitrux12",
                TipoDeMotor = "Electrico"
            };
            carro.Motor = motor;
            Cliente cliente1 = new Cliente();
            Vehiculo arrancar = new Vehiculo();
            Console.WriteLine(cliente1.Nombre + cliente1.Apellido);
            Console.Write(cliente.Comprar());
            Console.WriteLine(cliente.Mostrarvehiculo());
            Console.WriteLine(carro.MostrarMotor());
            Console.WriteLine(arrancar.Arrancar());
            Console.WriteLine("El consumo por un mes en galones es de:" + carro.Consumo(1, 30, 2));
            Console.ReadKey();
        }
    }
}


using System;

namespace ConsoleEmpresa
{
    class Vehiculo:Motor
    {
  
        public string Modelo { get; set; }  
        public string Color {  get; set; }
        
        public Cliente Propietario { get; set; }

       
        public Motor Motor { get; set; }
        
        public string MostrarMotor()
        {
            return $"Este vehiculo tiene un motor de la marca {Motor.Marca}";
        }

        public string Acelerar()
        {
            return "Pudeo acelerar";
        }
        public string Desacelerar()
        {
            return "Pudeo desacelerar";
        }
        public int Consumo(int num_consumo,int dias_mes)
        {
            return num_consumo * dias_mes;
        }
        public int Consumo(int num_consumo, int dias_mes, int num_horas)
        {
            return num_consumo * dias_mes * num_horas;
        }
        public Vehiculo() : base()
        {
            Modelo = "Aveo family";
            Color = "Azul";
        }

        
        public new string Arrancar()
        {
            return $"el modelo {this.Modelo} tiene el color {this.Color} esta {base.Arrancar()}";
        }


    }
}

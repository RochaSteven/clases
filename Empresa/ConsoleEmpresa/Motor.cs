

namespace ConsoleEmpresa
{
    class Motor
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string TipoDeMotor { get; set; }

        public string Arrancar()
        {
            return "Pudeo arrancar";
        }
        public string Apagar()
        {
            return "Pudeo apagarmer";
        }
    }
}

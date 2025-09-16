namespace ClasesEjercicioPrueba.Models
{
    public class Vehiculo
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string patente { get; set; }
        public int cantidadPuertas { get; set; }
        public string motor { get; set; }

        public int CapacidadCarga { get; set; }
        public bool tieneAuxiliar { get; set; }

        public Vehiculo(string patente, string marca, string Modelo, int CapacidadCarga)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = Modelo;
            this.CapacidadCarga = CapacidadCarga;
        }

    }
}

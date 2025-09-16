using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicioPrueba.Models
{
    public class Viajes
    {
        public int Id { get; set; }
        public string Origen {  get; set; }
        public string Destino { get; set; }
        public DateTime Fecha { get; set; }
        public int DistanciaKM { get; set; }
        public int VehiculoID { get; set; }
    }
}

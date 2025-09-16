using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesEjercicioPrueba.Data1;
using ClasesEjercicioPrueba.Models;

namespace ClasesEjercicioPrueba.Repository
{
    public static class VehiculoRepository
    {
        public static List<Vehiculo> vehiculos = new List<Vehiculo>();
        public static void GuardarVehiculo(Vehiculo vehiculo)
        {
            using var context = new ApplicationDbContext();
            context.vehiculos.Add(vehiculo);

            context.SaveChanges();
        }

        public static List<Vehiculo> ObtenerVehiculos()
        {
            using var context = new ApplicationDbContext();
            return context.vehiculos.ToList();
        }

        public static bool Corroborarpatente(string patente)
        {
            foreach (var v in vehiculos)
            {
                if (v.patente == patente)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

using ClasesEjercicioPrueba.Models;
using ClasesEjercicioPrueba.Repository;


List<Vehiculo> vehiculos = VehiculoRepository.ObtenerVehiculos();

Console.WriteLine("Elija una opcion");
Console.WriteLine("1. Registrar nuevo vehiculo: ");
Console.WriteLine("2. Registrar nuevo viaj:  ");
Console.WriteLine("3. Actualizar capacidad de carga de un vehiculo ");
Console.WriteLine("4. Eliminar Vehiculo ");
Console.WriteLine("5. Eliminar viaje ");
Console.WriteLine("6. Listar todos los vehiculos con sus viajes ");
Console.WriteLine("7. Estadisticas de viajes ");
Console.WriteLine("8 Salir");
string eleccion = Console.ReadLine();

switch (eleccion)
{
    case "1":
        Console.WriteLine("Ingrese la patente del vehiculo");
        string patente = Console.ReadLine();

        bool existe = VehiculoRepository.Corroborarpatente(patente);

        if (existe)
            Console.WriteLine("Ya existe un auto con esa patente ");
        else
        {
            Console.WriteLine("Ingrese el modelo del vehiculo");
            string modelo = Console.ReadLine();
            Console.WriteLine("Ingrese la marca del vehiculo");
            string marca = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de puertas del vehiculo");
            int cantidadPuertas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el motor del vehiculo");
            string motor = Console.ReadLine();
            Console.WriteLine("Ingrese la carga del vehiculo: ");
            int capacidadcarga = int.Parse(Console.ReadLine());

            Vehiculo vehiculo = new Vehiculo(patente, marca, modelo, capacidadcarga)
            {
                modelo = modelo,
                marca = marca,
                patente = patente,
                cantidadPuertas = cantidadPuertas,
                motor = motor
            };

            VehiculoRepository.GuardarVehiculo(vehiculo);
            Console.WriteLine("Vehiculo guardado con exito");
        }
        break;
    case "2":
        Console.WriteLine("Ingrese la patente del vehiculo para el vaje: ");
        foreach (var mos in vehiculos)
        {
            Console.WriteLine($"Patente: {mos.patente}");
        }


        break;
    case "3":
        break;
    case "4":
        break;
    case "5":
        break;
    case "6":
        break;
    case "7":
        break;
    case "8":
        break;

}

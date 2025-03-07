using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeBusqueda
    //3
{
    public class Metodos
    {
        static void Main()
        {
            ManejadorDeDatos dataHandler = new ManejadorDeDatos();
            Console.WriteLine("Datos originales: " + string.Join(",", dataHandler.GetNumbers()));

            Console.WriteLine("\n¿Desea ordenar los datos antes de buscar (SI/NO)");
            if (Console.ReadLine().ToUpper() == "SI")
            {
                dataHandler.SortNumbers();
                Console.WriteLine("Datos ordenados: " + string.Join(",", dataHandler.GetNumbers()));
            }
            Console.Write("\nIngrese el numero a buscar: ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese el numero a buscar: ");
            Console.WriteLine("1. Busqueda Secuencial");
            Console.WriteLine("2. Busqueda Binaria (Debe incluir los datos ordenados)");
            int opcion = int.Parse(Console.ReadLine());

            int result = -1;
            if (opcion == 1)
                result = AlgoritmosDeBusquedas.BusquedaSecuencial(dataHandler.GetNumbers(), target);
            else if (opcion == 2)
                result = AlgoritmosDeBusquedas.BusquedaBinaria(dataHandler.GetNumbers(), target);
            else
                Console.WriteLine("Opcion no valida");
            Console.WriteLine(result != -1 ? $"Elemento encontrado en la posición {result}": "Elemento no encontrado." );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeBusqueda
    //2
{
    class ManejadorDeDatos
    {
        private int[] numbers;

        public ManejadorDeDatos()
        {
            LoadNumbers();
        }
        public void LoadNumbers()
        {
            string filePath = "numbers.txt";
            if (File.Exists(filePath))
            {
                numbers = File.ReadAllText(filePath)
                .Split(',')
                .Select(int.Parse)
                .ToArray();

            }
            else
            {
                Console.WriteLine("Archivo no encontrado. Creando archivo con datos predeterminados...");
                numbers = new int[] {5, 24, 28, 40, 20, 30 };
                File.WriteAllText(filePath, string.Join(",", numbers));
            }

        }
        public void SortNumbers()
        {
            Array.Sort(numbers);
        }
        public int[] GetNumbers()
        {
            return numbers;
        }

    }
}

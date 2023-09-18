using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio03_lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float promedio;
            int limite;
            Console.Write("Ingrese la cantidad de notas: ");
            limite = int.Parse(Console.ReadLine());
            int suma = 0;

            for (int i = 1; i <= limite; i++)
            {
                Console.Write("Ingrese la nota " + i + ": ");
                int numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
            }
            promedio = suma / limite;
            Console.WriteLine("El promedio de notas es: " + promedio);
            Console.ReadLine();
        }
    }
}

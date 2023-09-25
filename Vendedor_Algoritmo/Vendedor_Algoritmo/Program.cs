using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendedor_Algoritmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de articulos comprados: ");
            int cantidadArticulos = int.Parse(Console.ReadLine());

            //define el precio por articulos
            double PrecioPorArticulo;

            //Comprueba si la cantidad es menor o igual a 10
            if (cantidadArticulos <= 10)
            {
                PrecioPorArticulo = 20.0;
            }
            else
            {
                PrecioPorArticulo = 15.0;
            }

            //calcular el total final
            double total = cantidadArticulos + PrecioPorArticulo;

            //Muestra el precio final 
            Console.WriteLine($"Precio por articulos {PrecioPorArticulo}");
            Console.WriteLine($"Total a pagar {total}");

            Console.ReadLine();
        }
    }
}

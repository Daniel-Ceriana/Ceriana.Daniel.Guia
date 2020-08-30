using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";

            Int32 numeroMinimo;
            Int32 numeroMaximo;



            Console.WriteLine("Ingrese un año minimo para el rango");
            numeroMinimo = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Ingrese un año máximo para el rango");
                numeroMaximo = int.Parse(Console.ReadLine());
            } while (numeroMaximo < numeroMinimo);

            //if numero%4 == 0
            //!(if numero%100==0 && !numero%400==0)

            for (int i = numeroMinimo;i<=numeroMaximo;i++)
            {
                    //verifico que se cumplan las condiciones de año bisiesto(multiplo de 4, no de 100 a no ser que tambien sea de 400)
                if (i % 4 == 0 && !(i % 100 == 0 && !(i % 400 == 0)))
                {
                    Console.WriteLine("El año {0:#,###.00} es bisiesto", i);
                }
            }
            


            Console.ReadKey();








        }
    }
}

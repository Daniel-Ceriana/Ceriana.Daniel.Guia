using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio nro 02";

            double numero;
            
            bool error = false;

            do
            {


                Console.WriteLine("Ingrese un numero");
                numero = Single.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    
                    Console.WriteLine("El cuadrado del numero {0:#,###.00} es {1:#,###.00}", numero,Math.Pow(numero, 2));
                    Console.WriteLine("El cubo del numero {0:#,###.00} es {1:#,###.00}", numero,Math.Pow(numero, 3));
                }
                else
                {
                    error = true;
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }

            } while (error);

            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Ejercicio_11
    {
        //le faltan validaciones, fuera de eso funciona
        static void Main(string[] args)
        {
            bool valid = false;
            Int32 number;
            Int32 max = 0;
            Int32 min = 0;
            Int32 counter = 0;
            double average;

            Console.Title = "Ejercicio Nro 11";

            Console.WriteLine("Ingresar 10 números dentro del rango -100 a 100");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Numero a ingresar: {0}", i);
                number = int.Parse(Console.ReadLine());
                valid = Validacion.Validar(number, -100, 100);
                if (valid)
                {
                    if (i == 0)
                    {
                        max = number;
                        min = number;
                    }
                    else
                    {
                        if (number > max)
                            max = number;
                        if (number < min)
                            min = number;
                    }
                    counter += number;
                }
                else
                {
                    Console.WriteLine("El valor ingresado no esta dentro de los parámetros asignados, reintente");
                }

            }

            average = counter / 10;

            Console.WriteLine("El valor máximo es:{0:#,###.00}", max);
            Console.WriteLine("El valor mínimo es:{0:#,###.00}", min);
            Console.WriteLine("El promedio de valores es:{0:#,###.00}", average);


            Console.ReadKey();

        }
    }
}

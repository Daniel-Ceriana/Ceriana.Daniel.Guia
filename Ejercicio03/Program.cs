using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";

            Int32 numero;
            bool error = false;
            bool primo = true;

            do
            {
                Console.WriteLine("Ingrese un número");
                numero = int.Parse(Console.ReadLine());

                if (numero <= 0)
                {
                    error = true;
                    Console.WriteLine("Error, no se pueden ingresar numeros negativos ni 0");
                }
                for (Int32 i = 1; i < numero - 1; i++)
                {
                    for (Int32 j = 2; j< i;j++)
                    {
                        if (i % j == 0)
                        {
                            primo = false;
                            break;
                        }
                        else
                        {
                            primo = true;
                        }    
                    }                   
                    if(primo)
                    {
                        Console.Write("{0:#,###.00}|||", i);
                    }
                }



            } while (error);
            

            Console.ReadKey();

        }
    }
}

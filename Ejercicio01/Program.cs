using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            Int32 cantidadDeValoresAPedir = 5;

            bool primeraVez = true;
            Single numero = 0;
            Single maximo = 0;
            Single minimo = 0;
            Single promedio = 0;
            Single contador = 0;

            for(Int32 i = 0; i<cantidadDeValoresAPedir;i++)
            {
                Console.WriteLine("Ingrese el {0}° número", i+1);
                numero = float.Parse(Console.ReadLine());
                if (primeraVez || numero > maximo)
                {
                    maximo = numero;
                }
                if(primeraVez || numero < minimo )
                {
                    minimo = numero;
                    primeraVez = false;
                }
                contador += numero;
            }

            promedio = contador / cantidadDeValoresAPedir;

            Console.WriteLine("El valor maximo es: {0:#,###.00}", maximo);
            Console.WriteLine("El valor minimo es: {0:#,###.00}", minimo);
            Console.WriteLine("El promedio es: {0:#,###.00}", promedio);

            Console.ReadKey();
        }
    }
}

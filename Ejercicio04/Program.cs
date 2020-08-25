using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";

            Int32 numero = 1;
            bool encontrados = false;
            Int32 acumuladorDivisores = 0;
            Int32 contadorEncontrados = 0;

            //Console.WriteLine("Ingrese un numero");
            Console.WriteLine("Los siguientes numeros son perfectos: ");
            

            do
            {


                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)// si i es divisor del numero
                    {
                        acumuladorDivisores += i;// se suma en el contador para despues verificar que sea identico al numero en si
                    }
                }
                

                if (acumuladorDivisores == numero)//condicion para verificar que sea numero perfecto
                {
                    Console.WriteLine("El numero {0:#,###.00} es numero perfecto", numero);
                    contadorEncontrados++;
                }
                acumuladorDivisores = 0;//pequeña linea de codigo que tarde demasiado en darme cuenta que faltaba :')
                numero++;
                if(contadorEncontrados == 4)
                {
                    encontrados = true;
                }

                //Console.WriteLine("estamos verificando el numero: {0}", numero);
            } while (!encontrados);
            Console.ReadKey();



        }
    }
}

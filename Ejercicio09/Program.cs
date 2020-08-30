using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Ejercicio_09
    {
        static void Main(string[] args)
        {

            Int32 Quantity;

            string message = "*";

            Console.WriteLine("Ingrese la altura de la pirámide");
            Quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < Quantity; i++)
            {
                Console.WriteLine(message);
                message +=  "**";
            }


            Console.ReadKey();

        }
    }
}

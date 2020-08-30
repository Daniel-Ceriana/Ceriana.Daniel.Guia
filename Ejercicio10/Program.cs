using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Ejercicio_10
    {
        static void Main(string[] args)
        {

            Int32 Quantity;
            

            string message = "*";
            string messageLeft = "";

            Console.WriteLine("Ingrese la altura de la pirámide");
            Quantity = int.Parse(Console.ReadLine());

            if(Quantity>0)
                Console.WriteLine("{0,11}", message);

            for (int i = 0; i < Quantity; i++)
            {
                message += "*";
                messageLeft += "*";
                Console.WriteLine("{0,10}{1}",messageLeft,message);
            }


            Console.ReadKey();
        }
    }
}

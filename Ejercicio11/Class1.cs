using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {

        Int32 value;
        Int32 minimum;
        Int32 maximum;

        //Validar(value)


        public static bool Validar(int valor, int min, int max)
        {
            bool isValid = true;

            if (valor < min || valor > max)
                isValid = false;

            return isValid;
        }


    }
}

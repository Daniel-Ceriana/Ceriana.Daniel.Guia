using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Ejercicio_08
    {
        static void Main(string[] args)
        {
            Int32 cantidadEmpleados;



            #region variables auxiliares para empleado
            
            Int32 auxValorHora;
            Int32 auxAntiguedad;
            Int32 auxHorasTrabajadasPorMes;
            double auxImporteAPagar;
            string auxNombre;

            #endregion

            double auxImporteConDescuento;

            double totalPagarEmpleados = 0;


            LinkedList<Empleado> listaEmpleados = new LinkedList<Empleado>();
            //List<Empleado> listaEmpleados = new List<Empleado>();


            Console.WriteLine("Cuántos empleados se van a cargar en el sistema?");
            cantidadEmpleados = int.Parse(Console.ReadLine());

            for(int i = 0; i<cantidadEmpleados;i++)
            {
                Empleado auxEmpleado = new Empleado();//la direccion de memoria se guarda en la linked list, por lo que se destruye este objeto cada vez que itera y no se deberia perder la informacion
                //pido los datos
                Console.WriteLine("Ingrese el nombre del empleado cuyo id será: {0}", i+1);
                auxNombre = Console.ReadLine();
                Console.WriteLine("Ingrese el valor por hora del empleado cuyo id será: {0}", i + 1);
                auxValorHora = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la antigüedad del empleado cuyo id será: {0}", i + 1);
                auxAntiguedad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese las horas trabajadas por mes del empleado cuyo id será: {0}", i + 1);
                auxHorasTrabajadasPorMes = int.Parse(Console.ReadLine());
                //una vez que tengo todos los datos, creo un empleado nuevo en la lista y vuelvo a empezar

                auxImporteAPagar = auxValorHora * auxHorasTrabajadasPorMes;
                auxImporteAPagar += auxAntiguedad * 150;


                auxEmpleado.nombre = auxNombre;
                auxEmpleado.valorHora = auxValorHora;
                auxEmpleado.antiguedad = auxAntiguedad;
                auxEmpleado.horasTrabajadasPorMes = auxHorasTrabajadasPorMes;
                auxEmpleado.importeAPagar = auxImporteAPagar;
                
                
                listaEmpleados.AddLast(auxEmpleado);
            }




            /*
            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
            bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
            */
            Console.WriteLine("Nombre      antigüedad    valor de hora       Total bruto    Total descuento");
            foreach (Empleado thisEmpleado in listaEmpleados)//pienso que el problema puede estar en el tipo de dato Empleado y la declaracion de "thisEmpleado"
            {
                //descuento de 13%
                auxImporteConDescuento = thisEmpleado.importeAPagar * 0.87;
                totalPagarEmpleados += auxImporteConDescuento;

                Console.WriteLine("{0,-10}{1,5}{2,20:C}{3,23:C}{4,15:C}",thisEmpleado.nombre,thisEmpleado.antiguedad,thisEmpleado.valorHora,thisEmpleado.importeAPagar,auxImporteConDescuento);
            }

            Console.WriteLine("El total a pagar de todos los empleados es: {0:C}", totalPagarEmpleados);

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Ejercicio_07

    {
        static void Main(string[] args)
        {
            //#region código que funciona pero no resuelve el ejercicio

            
            DateTime dt = DateTime.Now;
            DateTime bdt;
            Int32 ageDay;
            Int32 ageMonth;
            Int32 ageYear;
            Int32 d,m,y;
            Int32 daysMonthsCounter = 0;
            Int32 leapYearsCounter = 0;
            Int32 age;

            string dateString;

            //Console.WriteLine(dt);

            //pido los datos
            Console.WriteLine("Ingrese el día de su nacimiento");
            d= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes de su nacimiento");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año de su nacimiento");
            y = int.Parse(Console.ReadLine());

            //cambio los datos a string
            dateString = d + "/" + m + "/" + y + " "+"00:00:00";

            //parseo los datos de string a DateTime
            bdt = DateTime.Parse(dateString);
            //Console.WriteLine(bdt);

            //comparo los datos para tener la diferencia entre cada valor
            ageDay = bdt.Day - dt.Day;
            ageMonth = bdt.Month - dt.Month;
            ageYear = bdt.Year - dt.Year;

            //si algun resultado da negativo tengo que cambiarle el signo para no ver numeros negativos
            if (ageDay < 0)
                ageDay *= -1;
            if (ageMonth < 0)
                ageMonth *= -1;
            if (ageYear < 0)
                ageYear *= -1;

           // Console.WriteLine("Tenés {0} años, con {1} meses y {2} días", ageYear, ageMonth, ageDay);
            
            //#endregion

            for(int i = 0; i<=ageMonth; i++)
            {
                if(i!=0)
                daysMonthsCounter += DateTime.DaysInMonth(dt.Year, i);
            }
            for(int i = y; i <= dt.Year; i++)
            {
                if (DateTime.IsLeapYear(i))           
                    leapYearsCounter++;

            }

            Console.WriteLine("Day: {0}", dt);
            Console.WriteLine("Day in: {0}", bdt);
            Console.WriteLine(" ageday {0}",ageDay);
            Console.WriteLine(" ageMonth {0}", ageMonth);
            Console.WriteLine(" ageYear {0}", ageYear);
            Console.WriteLine(" leapYearsCounter {0}", leapYearsCounter);
            Console.WriteLine(" daysMonthsCounter {0}", daysMonthsCounter);

            age = ageDay + daysMonthsCounter + ageYear*365 + leapYearsCounter;

            Console.WriteLine("Tenés {0} días vividos", age);

            Console.ReadKey();
            
        }
    }
}

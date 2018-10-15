using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Zadanie6
    {
        private double liczba;

        public Zadanie6(double liczba)
        {
            this.liczba = liczba;

            try
            {
                liczba = 1 / liczba;
                
            }

            catch (ArithmeticException) when (liczba == 0)
            {
                Console.WriteLine("Nie ma odwrotności 0!!");
            }

            Console.WriteLine("Odwrotność liczby to :" + liczba);

        }
    }
}

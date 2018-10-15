using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Zadanie4
    {
        public void Kalkulator(string wyrazenie)
        {
           
            string[] s = wyrazenie.Split(' ');
            double liczba1 = double.Parse(s[0].Replace(".", ","));
            double liczba2 = double.Parse(s[2].Replace(".", ","));
            char znak = char.Parse(s[1]);
            double wynik = double.NaN;
            switch (znak)
            {
                case '+':
                    wynik = liczba1 + liczba2;
                    break;
                case '-':
                    wynik = liczba1 - liczba2;
                    break;
                case '*':
                    wynik = liczba1 * liczba2;
                    break;
                case '/':
                    wynik = liczba1 / liczba2;
                    break;
            }

            Console.WriteLine("TWÓJ WYNIK TO:  ");
            Console.WriteLine("\t{0}", liczba1);
            Console.WriteLine("\t{0}", znak);
            Console.WriteLine("\t{0}", liczba2);
            Console.WriteLine("\t=");
            Console.WriteLine("\t{0}", wynik);
            Console.WriteLine();
            Console.ReadKey();
            
        }
    }
}

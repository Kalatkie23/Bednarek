using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Zadanie1
    {
        public void Witaj()
        {
            Console.WriteLine("Podaj imie:");
            string imie = Console.ReadLine();
            Console.WriteLine("Witaj " + imie + " !");
            Console.ReadKey();
        }
    }
}

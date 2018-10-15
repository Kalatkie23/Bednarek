using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Zadanie10
    {

        public void Suma()
        {



            

            
            double suma = 0;

            Console.WriteLine("Podaj ile liczb chcesz sumować: ");
            int size = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj liczbę:");
            
            for (int i = 0; i < size; i++)
            {
                double liczba = double.Parse(Console.ReadLine());
                suma += liczba;
            }
               
                
                
                Console.WriteLine("Suma tych liczb to:" + suma);
            

        }
    }
}

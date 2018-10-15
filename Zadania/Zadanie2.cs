using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Zadanie2
    {

        private int suma = 0;
        private float srednia = 0;
        private int min = 100000000;
        private int max = 0;

        public void Kalkulator()
        {
            Console.WriteLine("Podaj liczbę: ");
            int ilosc = int.Parse(Console.ReadLine());
            for (int i = 0; i < ilosc; i++)
            {
                Console.WriteLine("Podaj " + (i + 1) + " liczbę:");
                int liczba = int.Parse(Console.ReadLine());
                suma += liczba;

                if (liczba < min)
                {
                    min = liczba;
                }
                if (liczba > max)
                {
                    max = liczba;
                }

            }

            srednia = (float)suma / ilosc;



            Console.WriteLine("Suma = " + suma);
            Console.WriteLine("Średnia = " + srednia);
            Console.WriteLine("Minimum = " + min);
            Console.WriteLine("Maximum = " + max);
            Console.ReadKey();
        } } }
    


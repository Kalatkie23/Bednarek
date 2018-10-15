using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Zadanie8

    {
        public void Tablica()
        {
            
            Console.WriteLine("Podaj wielkosc tablicy:");
            int wielkosc = int.Parse(Console.ReadLine());
            int[] tab;
            tab = new int[wielkosc];
            for (int i = 1; i <wielkosc; i++)
            {
              
                tab[i] = i;
                Console.WriteLine(tab[i]);
            }
            Console.WriteLine("");
            for (int i = 1; i < wielkosc/2; i++)
            {
                int temp = tab[wielkosc-i];
                tab[wielkosc-i] = tab[i];
                tab[i] = temp;
            }
            for (int i = 1; i < wielkosc; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.ReadKey();


        }      
            
        

    }
}

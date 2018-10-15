using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor = 0;
            Console.WriteLine("Wybierz program: 1. 2. 3. 4. 5. 6. 7. 8. 9. 10.");
            wybor = int.Parse(Console.ReadLine());

            switch(wybor)
            {
                case 1:
                    {
                        Zadanie1 Bartek = new Zadanie1();
                        Bartek.Witaj();
                        break;
                    }
                case 2:
                    {
                        Zadanie2 liczby = new Zadanie2();
                        liczby.Kalkulator();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Podaj rozmiar: ");
                        int n = int.Parse(Console.ReadLine());

                        Zadanie3 kwadrat = new Zadanie3(n);
                        Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        Zadanie4 kalkulator = new Zadanie4();
                        Console.WriteLine("Podaj działanie oddzielone spacjami:");
                        string wyrazenie= Console.ReadLine();
                        kalkulator.Kalkulator(wyrazenie);
                        Console.ReadKey();
                        break;
                    }


                case 5:
                    {
                        Zadanie5 zad5 = new Zadanie5(int.Parse(Console.ReadLine()));
                        zad5.Schow();
                        Console.ReadKey();
                        break;
                    }
                case 6:
                    {
                        
                        Console.WriteLine("Podaj liczbę: ");
                        double liczba = double.Parse(Console.ReadLine());
                        Zadanie6 odwrotnosc = new Zadanie6(liczba);
                       
                        Console.ReadKey();
                        break;
                    }

                case 7:
                    {
                        
                        Zadanie5 zad7 = new Zadanie5(int.Parse(Console.ReadLine()));
                       
                        int liczba = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ilość liczb w tablicy: " + zad7.IleRazy(zad7.tab, liczba));

                        Console.ReadKey();
                        break;
                    }
                case 8:
                    {
                        Zadanie8 zadanie8 = new Zadanie8();
                        zadanie8.Tablica();
                        break;
                    }
                case 9:
                    {
                        Zadanie9 zadanie9 = new Zadanie9();
                        Console.WriteLine("Podaj ciąg znaków:");
                        string wyrazenie = Console.ReadLine();
                        zadanie9.TablicaZnakow(wyrazenie);
                        Console.ReadKey();
                        break;
                    }

                case 10:
                    {
                        Zadanie10 zadanie10 = new Zadanie10();
                       zadanie10.Suma();

                        Console.ReadKey();
                       
                        break;
                    }
            }

        }
    }
}

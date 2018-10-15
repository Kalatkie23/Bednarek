using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Zadanie5
    {
        public int[] tab;
        private int size;
        private int NumberOfOddNumbers;
        private int NumberOfEvenNumbers;
        private int NumberOfPositiveNumbers;
        private int NumberOfNegativeNumbers;

        Random rand = new Random();

        public Zadanie5(int N)
        {
            size = N;
            tab = new int[N];
            for (int i = 0; i < N; i++)
            {
                tab[i] = rand.Next(-101, 102); 
            }
        }

        public int CountOddNumbers()
        {
            NumberOfOddNumbers = 0;
            for (int i = 0; i < size; i++)
                if (tab[i] % 2 == 1)
                    NumberOfOddNumbers++;

            return NumberOfOddNumbers;
        }

        public int CountEvenNumbers()
        {
            NumberOfEvenNumbers = 0;
            for (int i = 0; i < size; i++)
                if (tab[i] % 2 == 0)
                    NumberOfEvenNumbers++;

            return NumberOfEvenNumbers;
        }

        public int CountPositiveNumbers()
        {
            NumberOfPositiveNumbers = 0;
            for (int i = 0; i < size; i++)
                if (tab[i] >= 0)
                    NumberOfPositiveNumbers++;

            return NumberOfPositiveNumbers;
        }

        public int CountNegativeNumbers()
        {
            NumberOfNegativeNumbers = 0;
            for (int i = 0; i < size; i++)
                if (tab[i] < 0)
                    NumberOfNegativeNumbers++;

            return NumberOfNegativeNumbers;
        }

        /****************************************************************
         *                          ZADANIE 7                           *
         *                                                              *
         ***************************************************************/

        public int IleRazy(int[] tab, int a)
        {
            int counter = 0;

            for (int i = 0; i < tab.Length; i++)
                if (tab[i] == a)
                    counter++;

            return counter;
        }

        /**************************************************************/

        public void Schow()
        {
            Console.WriteLine("Even Numbers: " + CountEvenNumbers());
            Console.WriteLine("Odd Numbers: " + CountOddNumbers());
            Console.WriteLine("Positive Numbers: " + CountPositiveNumbers());
            Console.WriteLine("Negative Numbers: " + CountNegativeNumbers());
        }
    }
}

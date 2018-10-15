using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Zadanie3
    {
        private int n;

        public Zadanie3(int rozmiar)
        {
            this.n = rozmiar;
            show();


        }

        private void show()
        {
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ( i*j == 0 || i == n-1 || j == n-1 || i == j || i == n-j-1 )
                    {
                        Console.Write("*");
                       
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }

}

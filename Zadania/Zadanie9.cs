using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Zadanie9
    {
        public void TablicaZnakow(string wyrazenie)
        {

            char[] tab = wyrazenie.ToCharArray();
            if (tab.Length > 30)
            {
                Console.WriteLine("Podałes za długi ciąg znaków");

            }


            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
          
            
          
            

            for (int i = 0; i < tab.Length; i++)
            {
                
                char letter = tab[i];
                if (letter>=65 && letter<=90 || letter>=97 && letter<=122)
                {

                    Console.Write(letter);
                }
                
                
            }

                

        }

    }
}

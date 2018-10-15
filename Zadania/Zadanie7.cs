using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Zadanie7
    {

        private int a;
        public int[] tab;
        
        Random rand = new Random();
        private int v;

        public Zadanie7(int v)
        {
            this.v = v;
        }

        public int IleRazy(int[] tab, int a)
        {
            this.a = a;
            int counter = 0;

            for (int i = 0; i < tab.Length; i++)
                if (tab[i] == a)
                    counter++;

            return counter;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Sumator
    {
        private int[] Liczby;

        public Sumator(int[] Liczby) { this.Liczby = Liczby; }
        public int Suma()
        {
            int suma = 0;

            foreach (int liczba in Liczby)
            {
                suma += liczba;
            }

            return suma;
        }
        public int SumaPodziel3() {
            int suma3 = 0;

            foreach (int liczba in Liczby)
            {
                if (liczba % 3 == 0)
                {
                    suma3 += liczba;
                }
            }
            return suma3; 
        }
        public int IleElementow() {
            int elementy = 0;

            foreach (int liczba in Liczby)
            {
                    elementy += 1;
            }

            return elementy;
        }
        public void WypiszElementy()
        { 
            foreach (int liczba in Liczby)
            {
                Console.Write(liczba);
            }
        }

        public void LiczbyPomiedzyIndex(int lowIndex, int highIndex)
        {
                for (int i = 0; i < Liczby.Length; i++)
                {
                    if (i >= lowIndex && i <= highIndex)
                {
                    Console.Write(Liczby[i]);
                }
                }
            
        }
        
    }
}

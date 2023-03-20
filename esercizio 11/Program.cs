using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[10];
            int[] b = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Inserisci valore");
                a[i]=Convert.ToString(Console.ReadLine());
                int j = 0;
                bool r = int.TryParse(a[i], out j);
                if(r==true)
                {
                    Console.WriteLine("Valore verificato");
                }
                else
                {
                    Console.WriteLine("Valore non intero");
                }
            }
        }
    }
}

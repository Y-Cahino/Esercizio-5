using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire dimensione array: ");
            int d=int.Parse(Console.ReadLine());
            int[] a = new int[d];
            for(int i = 0; i < d; i++)
            {
                Console.WriteLine("Inserisci numero:");
                int x=int.Parse(Console.ReadLine());
                
            }
            posneg(a, x);
        }
        static void posneg(int []a, int x)
        {
            for(int pos=0; x>=0;pos++)
            {
                Console.WriteLine(pos);
            }
            
            for(int neg = 0; x < 0;neg++)
            {
                Console.WriteLine(neg);
            }
            
        }
    }
}

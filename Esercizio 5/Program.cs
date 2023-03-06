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
            int pos=0;
            int neg = 0;
            Console.WriteLine("Inserire dimensione array: ");
            int d=int.Parse(Console.ReadLine());
            int[] a = new int[d];
            for(int i = 0; i < d; i++)
            {
                Console.WriteLine("Inserisci numero:");
                int x=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("I numeri positivi sono: "+pos+"\nI numeri negativi sono: "+neg);
            posneg(pos, x, neg);
        }
        static void posneg(int pos,int x, int neg)
        {
            if(x>=0)
            {
                pos++;
            }
            
            else
            {
                neg++;
            }
            
        }
    }
}

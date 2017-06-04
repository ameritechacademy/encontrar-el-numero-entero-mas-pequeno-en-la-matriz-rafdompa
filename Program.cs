using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Katas1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class Kata
    {
        public static int FindSmallestInt(int[] args)
        {
            if (args.Length == 0)
                throw new ArgumentException();

            int menor = args[0];
            foreach (int x in args)
            {
                if (x < menor)
                {
                    menor = x;
                }
            }

            return menor;
        }
    }
}
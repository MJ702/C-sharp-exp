using System;

namespace exp4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] a = {1 , 2, 3, 4, 5};
            int[] b = {1 , 2, 3, 4, 5};

            for (var i = 0; i < a.Length; i++)
            {
                Console.Write( a[i] * b[i] + " ");
            }
        }
    }
}
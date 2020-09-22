using System;

namespace exp6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] item = new[] { 1, 2, 3 };       
            int[] result = new int[3];            
          

            for (int i = 0; i < item.Length; i++)
            {
                result[i] = item[(i + 1) % 3];
            }

            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}
using System;

namespace exp5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your first Number: ");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second Number: ");
            var y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third Number: ");
            var z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Max number is = {0}", Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("Min number is = {0}", Math.Min(x, Math.Min(y, z)));
        }
    }
}
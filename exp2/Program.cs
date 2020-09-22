using System;

namespace exp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your first Number");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second Number");
            var b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third Number");
            var c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("answer is (a + b).c = {0}", (a + b)*c);
            Console.WriteLine("answer is (a + b) + (b + c)  = {0}", (a * b)+ (b * c));
        }
    }
}
using System;
namespace exp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter your first nubmer");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            var b = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("adding= {0}", (a + b));
            Console.WriteLine("subtracting= {0}", (a - b));
            Console.WriteLine("mul= {0}", (a * b));
            Console.WriteLine("div= {0}", (a / b));
        }
    }
}
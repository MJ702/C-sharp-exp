using System;

namespace exception_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your number : ");
            int num = Convert.ToInt32(Console.In.ReadLine());

            try{
            
                if(num % 2 == 1){
                    throw new ArithmeticException();
                }
           
            }
            catch (ArithmeticException){
                Console.WriteLine("Error! : number is odd");
            }
        }
    }
}
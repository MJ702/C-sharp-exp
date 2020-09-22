using System;

namespace exception_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int  result = 0;

            Console.WriteLine("enter first value : ");
            int num1 = Convert.ToInt32(Console.In.ReadLine());


            Console.WriteLine("enter second value : ");
            int num2 = Convert.ToInt32(Console.In.ReadLine());



            try{
                result = num1 / num2;
            }
            catch(DivideByZeroException e){
                Console.WriteLine("Exception caught : {0}",e.Message);
            }
            finally{
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
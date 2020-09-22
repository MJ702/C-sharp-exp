using System;

namespace exp7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num = 16;
            
            object obj = num; 

            num = 702;
            Console.WriteLine("Orginal num = {0}", num);
            Console.WriteLine("Obj num = {0}", obj);


            int x = (int)obj;

            Console.WriteLine("Obj num = {0}", num);
            Console.WriteLine("x value = {0}", obj);
        }
    }
}
using System;

namespace exp3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your string");
            string str = Console.ReadLine();
            String[] words = str.Split(new[] {" "}, StringSplitOptions.None);

            int Max = 0;
            string temp = "";
            
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > Max)
                {
                    temp = words[i];
                    Max = words[i].Length;
                }
                else{
                    temp = " ";
                }
            }

            Console.WriteLine("word is = {0}", temp);
        }
    }
}
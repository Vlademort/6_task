using System;

namespace _6._2_task
{
    class Program
    {        
        static void Main(string[] args)
        {
             
            
            string start_string = Console.ReadLine();
            string result_string_1 = start_string.Replace(" ", "").ToLower();

            char[] revers_string = result_string_1.ToCharArray();
            Array.Reverse(revers_string);
            string result_string_2 = new String(revers_string).ToLower();

            Console.WriteLine();
            Console.WriteLine("{0}", result_string_1);
            Console.WriteLine();
            Console.WriteLine("{0}", result_string_2);

            if (result_string_1 == result_string_2)
            {
                Console.WriteLine();
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Строка НЕ является палиндромом");
            }
            
            Console.ReadKey();
        }
    }
}

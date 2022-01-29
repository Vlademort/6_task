using System;

namespace _6._1_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string start_string = Console.ReadLine();
            string result_string = "";
            string[] string_array = start_string.Split(' ');
            int n = 0;
            int max = 0;
            foreach (string s in string_array)
            {
                int length = s.Length;
                n += 1;
                Console.WriteLine($"Слово {n}: {s}, количество символов {length}");
                if (length > max)
                {
                    max = length;
                    result_string = s;
                }                                    
            }
            Console.WriteLine();
            Console.WriteLine($"Самое длинное слово: \"{result_string}\" с количеством симолов {max}");
            Console.ReadKey();
        }
    }
}

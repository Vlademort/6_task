using System;

namespace _6._3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            string my_string = "Дана строка{ S}. {Из строки} требуется удалить текст{, заключенный {в фигурные скобки}}!";
            Console.WriteLine("{0}", my_string);
            Console.WriteLine();
            int count = 0;
            string substring_1 = "{";
            string substring_2 = "}";
            bool symbol_1 = my_string.Contains(substring_1);
            bool symbol_2 = my_string.Contains(substring_2);
            int index = 0;            

            char[] chars = my_string.ToCharArray();

            for (int i = 0; i < my_string.Length; i++)
            {
                string s = chars[i].ToString();
                if (s == "{" || s == "}")
                {
                    count++;
                }
            }

            int[] array = new int[count];
            for (int k = 0; k < count; k++)
            {
                if (symbol_1 && symbol_2)
                {
                    for (int i = index; i < my_string.Length; i++)
                    {
                        String sub_1 = my_string.Substring(i, 1);
                        if (sub_1 == "{")
                        {
                            int index_1 = i + 1;
                            array[k] += i;
                            index = index_1;
                            break;
                        }

                        String sub_2 = my_string.Substring(i, 1);
                        if (sub_2 == "}")
                        {
                            int index_2 = i + 1;
                            array[k] += i;
                            index = index_2;
                            break;
                        }
                    }
                    //Console.Write("{0} ", array[k]);
                }
            }
            Console.WriteLine();


            for (int i = count - 1; i < count; i = i - index)
            {
                if (i<0)
                {
                    break;
                }
                {
                    if (my_string.Substring(array[i], 1) == substring_2 && my_string.Substring(array[i - 1], 1) == substring_1)
                    {
                        int a = array[i - 1];
                        int b = array[i] - array[i - 1] + 1;
                        my_string = my_string.Remove(a, b);
                        index = 2;
                    }
                    else
                    {
                        if (my_string.Substring(array[i], 1) == substring_2 && my_string.Substring(array[i - 3], 1) == substring_1)
                        {
                            int a = array[i - 3];
                            int b = array[i] - array[i - 3] + 1;
                            my_string = my_string.Remove(a, b);
                            index = 4;
                        }
                    }
                }
                
            }
            Console.Write("{0} ", my_string);
            Console.ReadKey();
        }
    }
}

using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //отсортировать одномер масивы
            //1й способ
            int[] array = { -8, 6, 0, 11, 4, -4, 3 };
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] > array[j])
            //        { int p = array[i]; array[i] = array[j]; array[j] = p; }



            //    }
            //}
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    Console.WriteLine($"array[i]={array[i]}");
            //}
            //Console.ReadKey();

            Array.Sort(array);
            foreach (int elem in array)
            {
                Console.WriteLine($"{elem}\t");

            }
            Array.Reverse(array);

        }      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите элементы массива через прабел");
            int[] arr = ReadArray(n);

            ReverseInPlace(arr);
            Console.WriteLine($"Перевернутый массив");
            PrintArray(arr);
        }

        public static int[] ReadArray(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"array[{n}]");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
        }

        public static void ReverseInPlace(int[] array)
        {
            for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            {
                int t = array[i];
                array[i] = array[j]; 
                array[j] = t;
            }
        }
    }
}

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

        public static int[] ReadArray(int N)
        {
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"array[{i}]");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        public static void PrintArray(int[] arrayP)
        {
            for (int i = 0; i < arrayP.Length; i++)
            {
                Console.WriteLine(arrayP[i]);
            }
            Console.WriteLine();
        }

        public static void ReverseInPlace(int[] arrayR)
        {
            for (int i = 0, j = arrayR.Length - 1; i < j; i++, j--)
            {
                int t = arrayR[i];
                arrayR[i] = arrayR[j]; 
                arrayR[j] = t;
            }
        }
    }
}

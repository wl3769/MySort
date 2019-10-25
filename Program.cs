using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int[] arr = {23, 44, 66, 76, 98, 11, 3, 9, 7};
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("排序后的数组：");
            foreach (int item in arr)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

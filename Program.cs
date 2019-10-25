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

            int n;
            Console.WriteLine("请输入数字个数：");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine("请输入第{0}个数字：", k + 1);
                arr[k] = int.Parse(Console.ReadLine());
            }
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j + 1];
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

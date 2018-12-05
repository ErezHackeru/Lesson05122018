using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05122018
{
    class Program
    {
        static void Main(string[] args)
        {
            int godel = 30;
            int[] arr = Create10(godel);
            PrintArr(arr);

            double[] newArr = arrIntToDouble(arr);
            PrintArr(newArr);
            Console.ReadLine();
        }

        private static double[] arrIntToDouble(int[] arr)
        {
            double[] newArr = new double[arr.Length];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = Convert.ToDouble(arr[i]);
            }
            return newArr;
        }

        private static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"The array in place {i} is {arr[i]} type: {arr[i].GetType()}");
            }
            Console.WriteLine();
        }
        private static void PrintArr(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"The array in place {i} is {arr[i]} type: {arr[i].GetType()}");
            }
            Console.WriteLine();
        }
        private static int[] Create10(int arrGodel)
        {
            Random x = new Random();
            int[] arrCreated = new int[arrGodel];

            for (int i = 0; i < arrCreated.Length; i++)
            {
                arrCreated[i] = x.Next(1, 1001);
            }


            return arrCreated;
        }
    }
}

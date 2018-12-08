using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_5
{
    class HW0512_Q5
    {
        static void Main(string[] args)
        {
            int[] arr = { -5, -10, 15, 2, 5, 100 };

            //SortArray1(arr); - my way to sort an array
            SortArray2(arr); //- the teacher's way to sort

            PrintArray(arr);

            Console.ReadLine();
        }

        private static void SortArray2(int[] arr)
        {
            int min = int.MaxValue;
            int minPlace = 0, Val = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                min = int.MaxValue;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        minPlace = j;
                    } 
                }
                Val = arr[i];
                arr[i] = arr[minPlace];
                arr[minPlace] = Val;
            }

        }

        private static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        private static void SortArray1(int[] arr)
        {
            int smallerVal = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        smallerVal = arr[i];
                        arr[i] = arr[j];
                        arr[j] = smallerVal;
                    }
                }
                
            }
        }
    }
}

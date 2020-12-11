using System;

namespace InsertionSort
{
    class Sorting
    {
        public static void InsertionSort(int[] arr)
        {
            int j, temp;
            for (int i = 1; i <= arr.Length - 1; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 1, 5, 4, 11, 20, 8, 2, 98, 90, 16 };

            Console.WriteLine("Unsorted array:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "  ");
            

            Sorting.InsertionSort(arr);

            Console.WriteLine("\nSorted array:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i]+"  ");
            Console.ReadKey();
        }
    }
}

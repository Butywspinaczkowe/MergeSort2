using System;

namespace MergeSort2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge Sort");

            int[] randomArray = Helper.Populate(100);

            Console.WriteLine("Here is a randomly populated array: ");

            Helper.WriteArray(randomArray);

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 3, 8));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 2, 6));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 2, 7));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 1, 7));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 1, 8));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 2, 9));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 1, 9));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 0, 10));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 0, 9));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 1, 10));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 1, 50));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 20, 100));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 0, 100));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 12, 43));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 11, 43));

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 12, 44));

            Console.WriteLine("\nHere is that array sorted using merge sort for the whole array:");
           
            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 1, 100));

            Helper.WriteArray(Sort.MergeSort(randomArray));
        }
    }
}

using System;

namespace MergeSort2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge Sort");

            int[] randomArray = Helper.Populate(10);

            Console.WriteLine("Here is a randomly populated array: ");

            Helper.WriteArray(randomArray);

            Console.WriteLine("\nHere is that array sorted using merge sort between indexes:");

            Helper.WriteArray(Sort.MergeSort(randomArray, 2, 7));

            Console.WriteLine("\nHere is that array sorted using merge sort for the whole array:");

            Helper.WriteArray(Sort.MergeSort(randomArray));
        }
    }
}

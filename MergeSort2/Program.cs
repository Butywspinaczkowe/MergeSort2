using System;

namespace MergeSort2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge Sort");

            int[] randomArray = Populate(101);
            Console.WriteLine("Here is a randomly populated array: ");
            WriteArray(randomArray);
            Console.WriteLine("\nHere is that array sorted using merge sort:");
            WriteArray(Sort.MergeSort(randomArray));

            



            


            static int[] Populate(int arrayLength)
            {
                int[] outputArray = new int[arrayLength];

                for (int i = 0; i < arrayLength; i++)
                {
                    outputArray[i] = RandomNumGen(101);
                }
                return outputArray;
            }

            static int RandomNumGen(int max)
            {
                Random randNum = new Random();
                return randNum.Next(max);
            }

            static void WriteArray(int[] inputArray)
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    Console.Write(inputArray[i] + " ");
                }
            }

        }
    }
}

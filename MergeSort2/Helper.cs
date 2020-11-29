using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort2
{
    class Helper
    {
        public static int[] Populate(int arrayLength)
        {
            int[] outputArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                outputArray[i] = RandomNumGen(100);
            }
            return outputArray;
        }

        public static int RandomNumGen(int max)
        {
            Random randNum = new Random();
            return randNum.Next(max);
        }

        public static void WriteArray(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }
        }
    }
}

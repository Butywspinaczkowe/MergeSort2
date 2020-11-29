using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort2
{
    class Sort
    {
        public static int[] MergeSort(int[] inputArray, int lowValue, int highValue)
        {
            if (inputArray.Length <= 1)
            {
                return inputArray;
            }

            int[] leftArray = new int[(highValue - lowValue) / 2];
            int[] rightArray = new int[(highValue - lowValue) / 2 + (highValue % 2)];

            for (int i = lowValue; i < highValue; i++)
            {
                if (inputArray.Length != highValue)
                {
                    if (i < highValue / 2 + (highValue % 2))
                    {
                        leftArray[i - lowValue] = inputArray[i];
                    }
                    else
                    {
                        rightArray[i - ((highValue / 2) + highValue % 2)] = inputArray[i];
                    }
                }
                else
                {
                    if (i < inputArray.Length / 2) // put the first half of the array into the left array
                    {
                        leftArray[i] = inputArray[i];
                    }
                    else // put the second half of the array into the right array
                    {
                        rightArray[i - inputArray.Length / 2] = inputArray[i];
                    }
                }

            }

            leftArray = MergeSort(leftArray);
            rightArray = MergeSort(rightArray);

            return Merge(leftArray, rightArray);
        }

        public static int[] MergeSort(int[] inputArray)
        {
            return MergeSort(inputArray, 0, inputArray.Length);
        }
        static int[] Merge(int[] leftArray, int[] rightArray)
        {
            int[] sortedList = new int[leftArray.Length + rightArray.Length]; // set up a list that combines both left and right but sorted
            int i = 0;
            while (leftArray.Length > 0 && rightArray.Length > 0) // while both left and right arrays still exist
            {
                if (leftArray[0] <= rightArray[0]) // if the first element on the left array is smaller
                {
                    sortedList[i] = leftArray[0]; //add that element to the sorted list
                    ResizeArray(ref leftArray); // remove the first element and reduce the size of the array (no pop method in c#)
                }
                else // same but on the right if that's smaller
                {
                    sortedList[i] = rightArray[0]; 
                    ResizeArray(ref rightArray);
                }
                i++;
            }
            while (leftArray.Length > 0)    // once left and right have been compared and there's only one array left just add them on the end
            {
                sortedList[i] = leftArray[0];
                ResizeArray(ref leftArray);
                i++;
            }
            while (rightArray.Length > 0)
            {
                sortedList[i] = rightArray[0];
                ResizeArray(ref rightArray);
                i++;
            }
            return sortedList;   // returns final sorted list
        }

        static int[] ResizeArray(ref int[] array)
        {
            int[] temp = new int[array.Length - 1];

            for (int i = array.Length - 1; i >= 1; i--)
                temp[i - 1] = array[i];

            array = temp;
            return array;
        }
    }
}

/*        public static int[] MergeSort(int[] inputArray) // splitting array in half repeatedly until you are left with an array of 1
        {
            if (inputArray.Length <= 1)  // base condition, when there is only one element in the array return that element
            {
                return inputArray;
            }

            int[] leftArray = new int[inputArray.Length / 2];  // Initialize arrays to be half the size of the incoming array (this is some c# nonsense)
            int[] rightArray = new int[inputArray.Length / 2 + (inputArray.Length % 2)];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i < inputArray.Length / 2) // put the first half of the array into the left array
                {
                    leftArray[i] = inputArray[i];
                }
                else // put the second half of the array into the right array
                {
                    rightArray[i - inputArray.Length / 2] = inputArray[i];
                }
            }

            leftArray = MergeSort(leftArray); // function calling itself in recursive loop the left array will get split in two using code above until it is an array of 1 that's returned
            rightArray = MergeSort(rightArray);

            return Merge(leftArray, rightArray); // once all arrays are one then start merging back together
        }*/
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
            int[] rightArray = new int[(highValue - lowValue) / 2 + ((highValue - lowValue) % 2)];

            for (int i = lowValue; i < highValue; i++)
            {
                    if (i < ((highValue + lowValue) / 2))
                    {
                        leftArray[i - lowValue] = inputArray[i];
                    }
                    else
                    {
                        rightArray[i - ((highValue + lowValue)/2)] = inputArray[i];
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
            int[] sortedList = new int[leftArray.Length + rightArray.Length];
            int i = 0;
            while (leftArray.Length > 0 && rightArray.Length > 0) 
            {
                if (leftArray[0] <= rightArray[0]) 
                {
                    sortedList[i] = leftArray[0];
                    ResizeArray(ref leftArray);
                }
                else 
                {
                    sortedList[i] = rightArray[0]; 
                    ResizeArray(ref rightArray);
                }
                i++;
            }
            while (leftArray.Length > 0)  
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
            return sortedList;  
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

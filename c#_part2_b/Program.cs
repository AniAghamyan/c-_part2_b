using System;

class Program
{
    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {

            int middle = (left + right) / 2;
            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);
            Merge(array, left, middle, right);
        }
    }
    static void Merge(int[] array, int left, int middle, int right)
    {
        int leftArraySize = middle - left + 1;
        int rightArraySize = right - middle;
        int[] leftArray = new int[leftArraySize];
        int[] rightArray = new int[rightArraySize];
        Array.Copy(array, left, leftArray, 0, leftArraySize);
        Array.Copy(array, middle + 1, rightArray, 0, rightArraySize);
        int i = 0, j = 0;
        int k = left;
        while (i < leftArraySize && j < rightArraySize)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }


        while (i < leftArraySize)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }


        while (j < rightArraySize)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }


    static void Main()
    {
        int[] array = { 38, 27, 43, 3, 9, 82, 10 };
        Console.WriteLine("Original Array:");
        Console.WriteLine(string.Join(" ", array));
        MergeSort(array, 0, array.Length - 1);
        Console.WriteLine("\nSorted Array:");
        Console.WriteLine(string.Join(" ", array));
    }
}


using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };

        Console.WriteLine("Original Array:");
        PrintArray(originalArray);

        Console.Write("Enter the number of elements in the filter array: ");
        int filterArraySize = int.Parse(Console.ReadLine());
        int[] filterArray = new int[filterArraySize];

        for (int i = 0; i < filterArraySize; i++)
        {
            Console.Write($"Enter element {i + 1} of the filter array: ");
            filterArray[i] = int.Parse(Console.ReadLine());
        }

        int[] filteredArray = FilterArray(originalArray, filterArray);

        Console.WriteLine("Filter Array:");
        PrintArray(filterArray);

        Console.WriteLine("Filtered Array:");
        PrintArray(filteredArray);
    }
    static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        return originalArray.Where(item => !filterArray.Contains(item)).ToArray();
    }
    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

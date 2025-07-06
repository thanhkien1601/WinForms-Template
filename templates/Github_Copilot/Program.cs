using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Create two lists of arrays not duplicating elements
        List<int> list1 = [3, 1, 4, 5, 9, 2, 6];
        List<int> list2 = [2, 7, 1, 8, 0, 21];

        // Sort both lists
        list1.Sort();
        list2.Sort();

        Console.WriteLine($"Sorted List 1: [{string.Join(", ", list1)}]");
        Console.WriteLine($"Sorted List 2: [{string.Join(", ", list2)}]");

        // Find intersection
        var intersection = FindIntersection(list1.ToArray(), list2.ToArray());

        Console.WriteLine($"Intersection: [{string.Join(", ", intersection)}]");
        Console.ReadLine();
    }

    static int[] FindIntersection(int[] array1, int[] array2)
    {
        var intersection = new List<int>();

        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                if (array1[i] == array2[j])
                {
                    intersection.Add(array1[i]);
                }
            }
        }

        return intersection.ToArray();
    }
}
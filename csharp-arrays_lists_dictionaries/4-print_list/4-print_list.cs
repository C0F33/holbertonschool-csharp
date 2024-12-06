using System;
using System.Collections.Generic;

class Program
{
    // Method to create and print a list
    public static List<int> CreatePrint(int size)
    {
        // Create a new list
        List<int> newList = new List<int>();

        // If size is negative, print error and return null
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        // Add elements to the list
        for (int i = 0; i < size; i++)
        {
            newList.Add(i);
            Console.Write(i); // Print each number in the list
            if (i != size - 1)
                Console.Write(" "); // Add space between elements, except the last one
        }
        // Add a dollar sign at the end of the line
        Console.WriteLine(); // Print new line at the end
        return newList;
    }
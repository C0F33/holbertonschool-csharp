using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        if (size == 0)
        {
            Console.WriteLine();
            return new int[0];
        }

        int[] result = new int[size];

        for (int i = 0; i < size; i++)
        {
            result[i] = i;
        }
        
        foreach (int num in result)
        {
            if (num != result[size - 1])
                Console.Write($"{num}, ");
            else
                Console.Write(num);
        }
        Console.WriteLine();

        return result;
    }
}
using System.Collections.Generic;
using System;

class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
        {
            throw new ArgumentException("Vectors must have the same length.");
        }

        double sum = 0;
        for (int i = 0; i < vector1.Length; i++)  // Fix loop condition
        {
            sum += vector1[i] * vector2[i];  // Compute dot product
        }

        return sum;  // Return result
    }
}
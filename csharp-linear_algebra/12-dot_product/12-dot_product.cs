using System.Collections.Generic;
using System;
/// <summary>
/// Empty
/// </summary>
class VectorMath
{
    /// <summary>
    ///  Matth class
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        
        if (vector1.Length != vector2.Length ||
            vector1.Length != 3 && vector1.Length != 2 || 
            vector2.Length != 3 && vector2.Length != 2){
            return (-1);

        double sum = 0;
        for (int i = 0; i < vector1.Length; i++)  // Fix loop condition
        {
            sum += vector1[i] * vector2[i];  // Compute dot product
        }

        return sum;  // Return result
    }
}
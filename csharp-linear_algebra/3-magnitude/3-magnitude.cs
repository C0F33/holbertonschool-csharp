﻿using System.Collections.Generic;
using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1; // Invalid vector size
        }

        double sum = 0;

        foreach (double component in vector)
        {
            sum += component * component;
        }

        return Math.Round(Math.Sqrt(sum), 2);
    }
}
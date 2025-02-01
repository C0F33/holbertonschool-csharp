using System;
using System.Collections.Generic;
/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// matrix addition
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns></returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
       /// first lets get our variables set up
       int row0 = matrix1.GetLength(0);
       int col0 = matrix1.GetLength(1);
       int row1 = matrix2.GetLength(0);
       int col1 = matrix2.GetLength(1);
       ///now check for matching lengths
       if row1 != row0 || col0 != col1
       {
           return new double[,] { { -1 } };
       }
       ///result variable set up
       double[,] result = new Double[,] {{row0, col0} };
       ///nested loops to iterate through values in matrix, columns and rows
       for (int i = 0; i < row0; i++)
       {
           for (int j =0; j < col0; j++)
           {
               result[i, j] = matrix1[i, j] + matrix2[i, j];
           }
       }
       return result;
    }
}

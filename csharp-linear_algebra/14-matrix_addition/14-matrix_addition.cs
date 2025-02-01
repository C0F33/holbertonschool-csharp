using System;

/// <summary>
/// MatrixMath class
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds two matrices if they have the same dimensions.
    /// </summary>
    /// <param name="matrix1">The first matrix.</param>
    /// <param name="matrix2">The second matrix.</param>
    /// <returns>
    /// A new matrix containing the sum of matrix1 and matrix2.
    /// Returns {{-1}} if the matrices cannot be added.
    /// </returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // Get dimensions of the matrices
        int row0 = matrix1.GetLength(0);
        int col0 = matrix1.GetLength(1);
        int row1 = matrix2.GetLength(0);
        int col1 = matrix2.GetLength(1);

        // Check if matrices have matching dimensions
        if (row1 != row0 || col0 != col1)
        {
            return new double[,] { { -1 } }; // Return error matrix
        }

        // Initialize result matrix with correct dimensions
        double[,] result = new double[row0, col0];

        // Nested loops to iterate through rows and columns
        for (int i = 0; i < row0; i++)
        {
            for (int j = 0; j < col0; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }
        
        return result;
    }
}
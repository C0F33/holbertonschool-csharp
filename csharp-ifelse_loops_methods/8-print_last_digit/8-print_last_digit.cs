using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        // Get the absolute value of the last digit
        int lastDigit = Math.Abs(number % 10);
        
        // Print the last digit
        Console.Write(lastDigit);
        
        // Return the last digit
        return lastDigit;
    }
}
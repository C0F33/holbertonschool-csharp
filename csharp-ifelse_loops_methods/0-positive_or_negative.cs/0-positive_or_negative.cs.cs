class Program
{
    static void Main()
    {
        Random rand = new Random();
        int number = rand.Next(-10, 11); // Random number between -10 and 10

        Console.WriteLine(number);

        if (number > 0)
        {
            Console.WriteLine("is positive");
        }
        else if (number == 0)
        {
            Console.WriteLine("is zero");
        }
        else
        {
            Console.WriteLine("is negative");
        }
    }
}
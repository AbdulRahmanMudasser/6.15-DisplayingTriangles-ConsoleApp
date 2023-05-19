class DisplayingTriangles
{
    static void Main(string[] args)
    {
        // Pattern 1
        Console.WriteLine("Pattern 1:");
        for (int row = 1; row <= 10; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Pattern 2
        Console.WriteLine("\nPattern 2:");
        for (int row = 10; row >= 1; row--)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Pattern 3
        Console.WriteLine("\nPattern 3:");
        for (int row = 1; row <= 10; row++)
        {
            for (int space = 1; space <= 10 - row; space++)
            {
                Console.Write(" ");
            }
            for (int col = 1; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Pattern 4
        Console.WriteLine("\nPattern 4:");
        for (int row = 10; row >= 1; row--)
        {
            for (int space = 1; space <= 10 - row; space++)
            {
                Console.Write(" ");
            }
            for (int col = 1; col <= row; col++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

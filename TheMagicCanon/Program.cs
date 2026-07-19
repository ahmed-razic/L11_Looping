namespace TheMagicCanon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" {i}: Electric and Fire");
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($" {i}: Fire");
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($" {i}: Electric");
                    continue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($" {i}: Normal");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
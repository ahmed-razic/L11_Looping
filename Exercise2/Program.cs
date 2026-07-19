namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number (or type 'exit' to quit):");
                string input = Console.ReadLine();

                if (input == "break" || input == "exit")
                {
                    break;
                }

                int number = int.Parse(input);

                if (number != 7)
                {
                    Console.WriteLine("You entered a number other than 7!");
                    continue;
                }
                Console.WriteLine("You entered the number 7!");
            }

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
            }

            int totalRows = 3;
            int totalCols = 2;

            for (int x = 0; x < totalRows; x++)
            {
                for (int y = 0; y < totalCols; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}


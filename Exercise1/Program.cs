namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
                if (x == 11)
                {
                    Console.WriteLine("x = 11...");
                    Console.WriteLine("Hello, World!");
                }
            }

            int playersNumber = -1;

            while(playersNumber < 0 || playersNumber >10)
            {
                Console.WriteLine("Please enter a number between 0 and 10");
                playersNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You entered: " + playersNumber);
            }
        }
    }
}

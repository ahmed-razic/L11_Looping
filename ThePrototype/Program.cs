namespace ThePrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToGuess;
            int number;

            do
            {
                Console.Write("User 1, enter a number between 1 and 100: ");
                numberToGuess = int.Parse(Console.ReadLine());
            } while (numberToGuess > 100 || numberToGuess < 0);

            Console.Clear();

            do
            {
                Console.Write("User 2, guess the number: ");
                number = int.Parse(Console.ReadLine());

                if (number > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else if (number < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }

            } while (number != numberToGuess);

            Console.WriteLine("Congratulations! You guessed the number! It was {0}.", numberToGuess);
        }
    }
}

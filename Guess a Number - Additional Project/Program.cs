namespace Guess_a_Number___Additional_Project;
class Program
{
    static void Main(string[] args)
    {
        Random rn = new Random();
        int chosenNumber = rn.Next(1, 101);

        string input = null;
        bool isInt = false;
        while (true)
        {
            Console.Write("Guess a number (1-100): ");
            input = Console.ReadLine();

            isInt = int.TryParse(input, out int a);

            if (!isInt || int.Parse(input) > 100 || int.Parse(input) < 1)
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                if (int.Parse(input) > chosenNumber)
                {
                    Console.WriteLine("Too High");
                }
                else if (int.Parse(input) < chosenNumber)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
            }
        }
    }
}
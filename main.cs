using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine($"Invalid value: {input}");
                continue;
            }

            if (number == 0)
            {
                Console.WriteLine("Closing program...");
                break;
            }

            // Generating centered triangular pattern
            for (int i = 1; i <= number; i++)
            {
                string spaces = new string(' ', number - i);
                string asterisks = new string('*', 2 * i - 1);
                Console.WriteLine(spaces + asterisks);
            }
        }
    }
}

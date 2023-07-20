namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char currentChar = input[0];
            int currentCount = 1;
            char highestChar = currentChar;
            int highestCount = currentCount;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > highestCount)
                    {
                        highestChar = currentChar;
                        highestCount = currentCount;
                    }
                    currentChar = input[i];
                    currentCount = 1;
                }
            }

            // Check if the last character had the highest count
            if (currentCount > highestCount)
            {
                highestChar = currentChar;
                highestCount = currentCount;
            }

            Console.WriteLine($"'{highestChar}' was entered {highestCount} times.");

        }
    }
}

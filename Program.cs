namespace _8._10._galgje;
class Program
{
    static void Main(string[] args)
    {
        int chances = 10;
        string secretWord = "programming";
        char[] secretWordChars;
        secretWordChars = secretWord.ToCharArray();
        char guessLetter = ' ';
        char[] result = new char[secretWordChars.Length];
        char[] result1 = new char[secretWordChars.Length];
        result1 = FillResult(result);

        do
        {
            guessLetter = Input.AskChar("Guess a letter of the word? \n");
            chances--;


            for (int i = 0; i < secretWordChars.Length; i++)
            {
                if (!(secretWordChars[i] == guessLetter))
                {
                    
                }
                else
                {
                    result1[i] = guessLetter;
                }

            }
            for (int i = 0; i < result1.Length; i++)
            {
                Console.Write(result1[i]);
            }
            Console.WriteLine();

        } while (chances > 0);
        Console.WriteLine("You lost!");








    }

    // Methods
    public static char [] FillResult(char [] result)
    {
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = '*';
        }

        return result;

    }
    // Classes
    public static class Input
    {
        public static string AskString(string question)
        {
            Console.Write($"{question}");
            return Console.ReadLine() ?? string.Empty;
        }
        public static int AskInteger(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (int.TryParse(Console.ReadLine(), out int r))
                    return r;

            }
        }
        public static char AskChar(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (char.TryParse(Console.ReadLine(), out char r))
                    return r;

            }


        }
    }
}

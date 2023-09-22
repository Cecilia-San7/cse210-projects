using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number? ");
        // string MagicNumber = Console.ReadLine();
        // int TheMagicNum = int.Parse(MagicNumber);

        Random randomGenerator = new Random();
        int TheMagicNum = randomGenerator.Next(1, 11);

        

        string lower = "lower";
        string higher = "higher";
    
        while (true)
        {
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            int MyGuess = int.Parse(guess);

            if (MyGuess == TheMagicNum)
            {
                Console.WriteLine("You guessed it!");
                break;
            }
            else if (MyGuess <= TheMagicNum)
            {
                Console.WriteLine(higher);
            }
            else if (MyGuess >= TheMagicNum)
            {
                Console.WriteLine(lower);
                
            }

     }
    }
}
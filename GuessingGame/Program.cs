using System;

namespace GuessingGame
{
    class Program
    {
        public static bool win = false;
        public static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a guessing game.");
            
            do 
            {
                GetGuessingGame();
            } while (win == false);
            
        }
        public static void GetGuessingGame()
        {
        int secretNumber = random.Next(1, 101);
        int numberOfTrials = 0;

        Console.WriteLine("Can you guess what number between 0 and 100 I am thinking of :-)");
            int input1 = Convert.ToInt32(Console.ReadLine());

            if (input1 > secretNumber)
            {
                Console.WriteLine("The number is lower.");
                numberOfTrials++;

            }
            else if (input1 < secretNumber)
            {
                Console.WriteLine("The number is higher.");
                numberOfTrials++;

            }
            else if ((input1 == secretNumber) && (numberOfTrials < 1))
            {
                numberOfTrials++;
                Console.WriteLine($"Well done! You are a mind reader. The number I was thinking of was {secretNumber}.");
                Console.WriteLine($"You guess it in the first shot!");
                win = true;
            }
            else if ((input1 == secretNumber) && (numberOfTrials > 1))
            {
                numberOfTrials++;
                Console.WriteLine($"Well done! You've got the right number. {numberOfTrials} was your lucky number, and also the number of trials you had before reaching the number, I was thinking of.");
                win = true;
            }
        }
    }
}

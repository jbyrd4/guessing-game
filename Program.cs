using System;
using System.Collections.Generic;

Random Rnd = new Random();
int SecretNumber = Rnd.Next(1, 100);
int Answer = 0;
int Guesses = 0;

Console.WriteLine("Please choose a difficulty level: (1: Easy, 2: Medium, 3: Hard, 4: Cheater)");
int difficulty = int.Parse(Console.ReadLine());

if (difficulty > 4)
{
    Console.WriteLine("You did not select an existing difficulty");
}
else
{

    if (difficulty == 1)
    {
        Guesses = 8;
    }
    else if (difficulty == 2)
    {
        Guesses = 6;
    }
    else if (difficulty == 3)
    {
        Guesses = 4;
    }
    else if (difficulty == 4)
    {
        Guesses = 4;
    }

    for (int i = 0; i < Guesses; i++)
    {
        Console.WriteLine("Guess a secret number: ");
        Answer = int.Parse(Console.ReadLine());

        if (Answer != SecretNumber)
        {
            Console.WriteLine("______________________");
            Console.WriteLine("You did not guess the secret number");
            Console.WriteLine($"Your Guess ({Answer})");
            if (difficulty != 4)
            {
                Console.WriteLine($"You have {(Guesses - 1) - i} guesses remaining.");
            }
            else
            {
                Console.WriteLine("You have unlimited guesses remaining.");
            }

            if (Answer > SecretNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                Console.WriteLine("Your guess is too low.");
                Console.WriteLine("______________________");
            }
        }
        else
        {
            Console.WriteLine("You guessed the secret number!");
            Console.WriteLine($"Your Guess ({Answer})");
            i = Guesses;
        }
        if (difficulty == 4 && Answer != SecretNumber)
        {
            i = 0;
        }
    }

    Console.WriteLine($"The secret number was: {SecretNumber}");
}
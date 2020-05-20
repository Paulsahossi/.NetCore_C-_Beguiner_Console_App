using System;
using System.Collections.Generic;

namespace Hangman2
{
    class Program
    {
        static string correctWord = "hangman";
        static char [] letters;
        static Player player;

        static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();

        }
        private static void StartGame()
        {
            letters = new char[correctWord.Length];
            for (int i = 0; i < correctWord.Length; i++)
                letters[i] = '-';
            AskForUserName();

        }

        static void AskForUserName()
        {
            Console.WriteLine("Enter your name");
            string input = Console.ReadLine();

            if (input.Length >= 2)
               player = new  Player(input);
            else
                AskForUserName();
        }

        private static void PlayGame()
        {
            do
            {
                Console.Clear();
                DisplayedMaskWord();
                char guessedLetter = AskForLetter();
                CheckLetter(guessedLetter);
            } while (correctWord != new string(letters));

          
        }

        private static void CheckLetter(char guessedLetter)
        {
            for (int i = 0; i < correctWord.Length; i++)
            {
                if (guessedLetter == correctWord[i])
                {
                    letters[i] = guessedLetter;
                    player.Score++;
                }
            }
        }

        static void DisplayedMaskWord()
        {
            foreach (char item in letters)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        static char AskForLetter()
        {
            string input;
            do
            {
            Console.WriteLine("Enter a Letter");
            input = Console.ReadLine();
            } while (input.Length != 1);


            var letter = input[0];

            if (!player.GuessedLetters.Contains(letter))
                player.GuessedLetters.Add(letter);

            return letter;

        }


        private static void EndGame()
        {
            Console.WriteLine("Game over...");
            Console.WriteLine($"Thank you for playing {player.Name}");
            Console.WriteLine($"Guesses : {player.GuessedLetters.Count} Score: {player.Score}");
        }

    }
}

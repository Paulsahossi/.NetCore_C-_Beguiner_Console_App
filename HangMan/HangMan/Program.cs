using System;
using System.Collections.Generic;
using System.IO;

namespace HangMan
{
    class Program
    {
        static string correctWord;
        static char[] letters;
        static Player player;
        static Random rand = new Random();
        static string filePath = "/Users/pawlus/Desktop/Hangman.txt";


        static void Main(string[] args)
        {
            try
            {
                SartGame();

                PlayGame();
                EndGame();

            }
            catch
            {
                Console.WriteLine("Oops, somthing went wrong...");

            }  


        }
        private static void SartGame()
        {
            string[] words;
            try
            {
                words = File.ReadAllLines(filePath);
            }
            catch
            {
                words = new string[] { "Tree", "Dog", "cat" };
            }

            correctWord = words[rand.Next(0, words.Length)];
            letters = new char[correctWord.Length];
            for (int i = 0; i < correctWord.Length; i++)
                letters[i] = '-';

            AskForUsersName();
        }

        static void AskForUsersName()
        {
            Console.WriteLine("Please enter your name");
            string input = Console.ReadLine();

            if (input.Length >= 2)
                player = new Player(input);
            
            else
            {
                AskForUsersName();
            }

        }

        private static void PlayGame()
        {
            do
            {
                Console.Clear();
                DisplaysMaskedWord();
                char guessedLetter = AskForLetter();
                checkLetter(guessedLetter);

            } while (correctWord != new string(letters));


            Console.Clear();

        }

        private static void checkLetter(char guessedLetter)
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

        static void DisplaysMaskedWord()
        {
            foreach (char c in letters)

                Console.Write(c);
            Console.WriteLine();
        }

        static char AskForLetter()
        {
            string input;

            do
            {
                Console.WriteLine("Enter a letter: ");
                input = Console.ReadLine();

            } while (input.Length != 1);

            var letter = input[0];

            if (!player.GuessedLetters.Contains(letter))
                player.GuessedLetters.Add(letter);

            return letter;

        }
        private static void EndGame()
        {
            
            Console.WriteLine("Congrats!");
            Console.WriteLine($"thank you for playing { player.Name}");
            Console.WriteLine($"Guesses: {player.GuessedLetters.Count} Score: {player.Score}");
        }

    }
}


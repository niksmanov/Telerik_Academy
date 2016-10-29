using System;


namespace TemplateMethod.Models
{
    public class Chess : Game

    {
        public override void InitializeGame()
        {
            Console.WriteLine("Initializing chess game...");
        }

        public override void StartOfGame()
        {
            Console.WriteLine("Choosing black or white figures!");
        }

        public override void EndOfGame()
        {
            Console.WriteLine("End of the game!");
        }

        public override void PrintWinner()
        {
            Console.WriteLine("The winner is white player!");
        }

        public override void Play()
        {
            InitializeGame();
            StartOfGame();
            EndOfGame();
            PrintWinner();
        }
    }
}

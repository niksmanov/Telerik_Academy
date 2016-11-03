using System;

namespace TemplateMethod.Models
{
    public class Monopoly : Game
    {
        public override void InitializeGame()
        {
            Console.WriteLine("Initializing monopoly game...");
        }

        public override void StartOfGame()
        {
            Console.WriteLine("Choosing players count...");
        }

        public override void EndOfGame()
        {
            Console.WriteLine("End of the game!");
        }

        public override void PrintWinner()
        {
            Console.WriteLine("The winner is second player!");
        }
              
    }
}

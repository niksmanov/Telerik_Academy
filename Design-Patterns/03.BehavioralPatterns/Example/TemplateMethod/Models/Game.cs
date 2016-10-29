
namespace TemplateMethod.Models
{
    public abstract class Game
    {
        public abstract void InitializeGame();
        public abstract void StartOfGame();
        public abstract void EndOfGame();
        public abstract void PrintWinner();
        public abstract void Play();
              
    }
}

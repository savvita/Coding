namespace Coding
{
    internal class Game: Item
    {
        public Game() : base("Game")
        {
            Items.Add(new Game2D());
            Items.Add(new Game3D());
        }
    }
}

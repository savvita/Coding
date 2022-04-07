namespace Coding
{
    internal class Game: Item
    {
        public Game() : base("Game", "Desciption for game")
        {
            Items.Add(new Game2D());
            Items.Add(new Game3D());
        }
    }
}

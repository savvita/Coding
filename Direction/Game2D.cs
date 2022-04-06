namespace Coding
{
    internal class Game2D: Item
    {
        public Game2D() : base("Game 2D")
        {
            Items.Add(new MobilePlatform());
            Items.Add(new Pc());
            Items.Add(new ConsolePlatform());
        }
    }
}

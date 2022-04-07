namespace Coding
{
    internal class Game2D: Item
    {
        public Game2D() : base("Game 2D", "Desciption for 2D games")
        {
            Items.Add(new MobilePlatform());
            Items.Add(new Pc());
            Items.Add(new ConsolePlatform());
        }
    }
}

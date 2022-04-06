namespace Coding
{
    internal class Game3D: Item
    {
        public Game3D() : base("Game 3D")
        {
            Items.Add(new MobilePlatform());
            Items.Add(new Pc());
            Items.Add(new ConsolePlatform());
        }
    }
}

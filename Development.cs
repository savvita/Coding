namespace Coding
{
    internal class Development: Item
    {
        public Development(): base("Development")
        {
            Items.Add(new Desktop());
            Items.Add(new Site());
            Items.Add(new Mobile());
            Items.Add(new Game());
        }
    }
}

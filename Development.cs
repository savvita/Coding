namespace Coding
{
    internal class Development: Item
    {
        public Development(): base("Development", "Desciption for development")
        {
            Items.Add(new Desktop());
            Items.Add(new Site());
            Items.Add(new Mobile());
            Items.Add(new Game());
        }
    }
}

namespace Coding
{
    internal class Desktop: Item
    {
        public Desktop() : base("Desktop")
        {
            Items.Add(new MacOS());
            Items.Add(new Windows());
        }
    }
}

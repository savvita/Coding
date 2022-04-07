namespace Coding
{
    internal class Desktop: Item
    {
        public Desktop() : base("Desktop", "Desciption for desktop")
        {
            Items.Add(new MacOS());
            Items.Add(new Windows());
        }
    }
}

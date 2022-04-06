namespace Coding
{
    internal class Site: Item
    {
        public Site() : base("Site")
        {
            Items.Add(new BackEnd());
            Items.Add(new FrontEnd());
        }
    }
}

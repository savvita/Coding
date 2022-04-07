namespace Coding
{
    internal class Site: Item
    {
        public Site() : base("Site", "Desciption for site")
        {
            Items.Add(new BackEnd());
            Items.Add(new FrontEnd());
        }
    }
}

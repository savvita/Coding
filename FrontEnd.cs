namespace Coding
{
    internal class FrontEnd : Item
    {
        public FrontEnd() : base("FrontEnd")
        {
            Items.Add(new HtmlCss());
            Items.Add(new React());
            Items.Add(new Angular());
            Items.Add(new Vue());
            Items.Add(new Razor());
        }
    }
}

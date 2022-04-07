namespace Coding
{
    internal class FrontEnd : Item
    {
        public FrontEnd() : base("FrontEnd", "Desciption for frontend")
        {
            Items.Add(new HtmlCss());
            Items.Add(new React());
            Items.Add(new Angular());
            Items.Add(new Vue());
            Items.Add(new Razor());
        }
    }
}

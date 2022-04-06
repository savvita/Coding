namespace Coding
{
    internal class BackEnd : Item
    {
        public BackEnd() : base("BackEnd")
        {
            Items.Add(new Java());
            Items.Add(new CSharp());
            Items.Add(new NodeJS());
            Items.Add(new Php());
            Items.Add(new Python());
            Items.Add(new Ruby());
        }
    }
}

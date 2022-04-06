namespace Coding
{
    internal class Pc : Item
    {
        public Pc() : base("PC")
        {
            Items.Add(new CPP());
            Items.Add(new CSharp());
        }
    }
}

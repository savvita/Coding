namespace Coding
{
    internal class Pc : Item
    {
        public Pc() : base("PC", "Desciption for PC")
        {
            Items.Add(new CPP());
            Items.Add(new CSharp());
        }
    }
}

namespace Coding
{
    internal class ConsolePlatform : Item
    {
        public ConsolePlatform() : base("Console", "Desciption for console")
        {
            Items.Add(new CPP());
            Items.Add(new CSharp());
        }
    }
}

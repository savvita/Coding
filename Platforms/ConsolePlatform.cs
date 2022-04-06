namespace Coding
{
    internal class ConsolePlatform : Item
    {
        public ConsolePlatform() : base("Console")
        {
            Items.Add(new CPP());
            Items.Add(new CSharp());
        }
    }
}

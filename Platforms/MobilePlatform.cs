namespace Coding
{
    internal class MobilePlatform : Item
    {
        public MobilePlatform() : base("Mobile platform")
        {
            Items.Add(new CPP());
            Items.Add(new CSharp());
        }
    }
}

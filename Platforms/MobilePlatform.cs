namespace Coding
{
    internal class MobilePlatform : Item
    {
        public MobilePlatform() : base("Mobile platform", "Desciption for mobile platform")
        {
            Items.Add(new CPP());
            Items.Add(new CSharp());
        }
    }
}

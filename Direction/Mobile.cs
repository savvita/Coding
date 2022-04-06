namespace Coding
{
    internal class Mobile : Item
    {
        public Mobile() : base("Mobile")
        {
            Items.Add(new Ios());
            Items.Add(new Android());
        }
    }
}

namespace Coding
{
    internal class Mobile : Item
    {
        public Mobile() : base("Mobile", "Desciption for mobile")
        {
            Items.Add(new Ios());
            Items.Add(new Android());
        }
    }
}

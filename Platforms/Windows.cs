namespace Coding
{
    internal class Windows : Item
    {
        public Windows() : base("Windows")
        {
            Items.Add(new Java());
            Items.Add(new Kotlin());
            Items.Add(new ReactNative());
            Items.Add(new Dart());
            Items.Add(new Python());
            Items.Add(new NodeJS());
            Items.Add(new CPP());
            Items.Add(new CSharp());
        }
    }
}

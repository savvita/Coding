namespace Coding
{
    internal class MacOS: Item
    {
        public MacOS(): base("MacOs", "Desciption for MacOS")
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

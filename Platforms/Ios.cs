namespace Coding
{
    internal class Ios: Item
    {
        public Ios(): base("iOS")
        {
            Items.Add(new Swift());
            Items.Add(new Dart());
            Items.Add(new ReactNative());
        }
    }
}

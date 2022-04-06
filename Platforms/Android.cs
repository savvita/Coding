namespace Coding
{
    internal class Android: Item
    {
        public Android(): base("Android")
        {
            Items.Add(new Java());
            Items.Add(new Kotlin());
            Items.Add(new ReactNative());
            Items.Add(new Dart());
        }
    }
}

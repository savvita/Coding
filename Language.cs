using System;

namespace Coding
{
    internal class Language: Item
    {
        public string Description { get; private set; }
        public Language(string name, string description): base(name)
        {
            Description = description;
        }

        public override void Show()
        {
            Console.WriteLine($"{Name}: {Description}");
        }
    }
}

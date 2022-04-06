using System;

namespace Coding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu(new Development());
            menu.Show();
        }
    }
}

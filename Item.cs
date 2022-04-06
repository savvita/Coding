﻿using System;
using System.Collections.Generic;

namespace Coding
{
    internal abstract class Item
    {
        public string Name { get; private set; }
        public List<Item> Items { get; protected set; }

        protected Item(string name)
        {
            Name = name;
            Items = new List<Item>();
        }

        public virtual void Show()
        {
            Console.WriteLine(Name);

            int i = 1;
            foreach(var item in Items)
            {
                Console.WriteLine($"\t{i++}. {item.Name}");
            }
        }

        public Item this[int index]
        {
            get
            {
                if(index >= 0 && index < Items.Count)
                    return Items[index];

                return null;
            }
        }
    }
}

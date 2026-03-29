using System;
namespace DZ2_sem2
{
	internal class Shelf
	{
        public string Name { get; }
        private readonly string[] slots;

        public Shelf(string name, int size)
		{
            Name = name;
            slots = new string[size];
		}

        public bool Put(int slot, string product)
        {
            if (slot < 1 || slot > slots.Length || slots[slot - 1] != null) return false;
            slots[slot - 1] = product;
            return true;
        }

        public string Take(int slot)
        {
            if (slot < 1 || slot > slots.Length || slots[slot - 1] == null) return null;
            string product = slots[slot - 1];
            slots[slot - 1] = null;
            return product;
        }

        public string Read(int slot)
        {
            if (slot < 1 || slot > slots.Length) return null;
            return slots[slot - 1];
        }
    }
}


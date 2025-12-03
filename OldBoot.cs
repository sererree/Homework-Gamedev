using System;
namespace dz6
{
	public class OldBoot : Item, IDiscardable
	{

        public OldBoot() : base("ботиночек", "когда-то любимый")
        {

        }

        public OldBoot(string name, string description) : base(name,description)
		{
			
		}

        public void Discard()
        {
           Console.WriteLine("Ты их выкинул");
        }
    }
}


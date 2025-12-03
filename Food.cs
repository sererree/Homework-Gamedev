using System;
namespace dz6
{
	public class Food : Item, IUsable, IStackable
	{
        public int energy = 40;
        public int Count { get; private set; } = 1;

        public Food() : base("еда", "восстанавливает энергию")
        {
           
        }


        public Food(string name, string description) : base(name,description)
		{
        
		}

        
        public void AddOne()
        {
            Count++;
        }

        public void RemoveOne()
        {
            if (Count > 0)
                Count--;
        }

        public void Use(Character user)
        {
           user.AddEnergy(energy);
        }
    }
}


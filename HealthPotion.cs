using System;
namespace dz6
{
	public class HealthPotion : Item, IUsable, IStackable
    {
        public int hp = 30;
        public int Count { get; private set; } = 1;

        public HealthPotion() : base("зелье здоровья", "восстанавливает 10хп")
        {
        }

        public HealthPotion(string name, string description) : base(name, description)
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
            user.AddHealth(hp);
            
        }

        
    }
}


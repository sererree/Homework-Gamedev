using System;
namespace dz6
{
	public class Scroll : Item, IUsable, ISellable
	{
		private int hp = 20;
		private int manna = 20;
		private int Price { get; set; } = 150;

        int ISellable.Price => throw new NotImplementedException();

        public Scroll(string name,string description) : base(name,description)
		{
			name = "свиток волшебный";
			description = "хиллит и дает энергию";
		}

        public Scroll() : base("свиток волшебный", "хиллит и дает энергию")
        {
    
        }




        public void Use(Character user)
        {
            user.AddHealth(hp);
			user.AddEnergy(manna);
        }

        public void Sell(Character user)
        {
            user.AddGold(Price);
        }
    }
}


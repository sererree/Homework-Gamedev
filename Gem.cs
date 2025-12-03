using System;
namespace dz6
{
    public class Gem : Item, ISellable
	{
		public int Price { get; set; } = 300;


        public Gem() : base("драгоценный камень", "совершенно бесполезен, только для продажи")
        { }
            
        public Gem(string name,string description): base(name, description)
		{
			
		}

        

        public void Sell(Character user)
        {
            user.AddGold(Price);
            //user.inventory.RemoveAt();
            //Console.WriteLine("Предмет удален");
        }

        
    }
}


using System;
using System.Diagnostics;

namespace dz6
{
    public class MagicRing : Item, IEquipable, ISellable
    {

        public int Price { get; set; } = 100;
        public MagicRing(string name, string description) : base(name, description)
        {
          
        }

        public MagicRing() : base("кольцо с зеленым камнем", "волшебное")
        {
        }

        public void Equip(Character user)
        {
            user.EquipRing(this);
        }

        public void Sell(Character user)
        {    
        user.AddGold(Price);
        }

    }
}


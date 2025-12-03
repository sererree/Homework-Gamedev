using System;
namespace dz6
{
	public class Armor : Item, IEquipable
    {
        public Armor() : base("драконья броня", "это драконья броня из скайрима")
        {
            
        }

        public Armor(string name, string description) : base(name, description)
		{
            
        }
        public void Equip(Character user)
        {
            user.EquipArmor(this);
        }

    }

}


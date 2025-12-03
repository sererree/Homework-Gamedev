using System;
namespace dz6
{
	public class Weapon : Item, IEquipable
    {
        public Weapon() : base("алмазный меч", "это алмазный меч из майнкрафта")
        {
        
        }

        public Weapon(string name, string description) : base(name,  description)
		{
			
		}
        public void Equip(Character user)
        {
            user.EquipWeapon(this);
        }
    }
}


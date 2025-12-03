using System;
using System.Net.NetworkInformation;

namespace dz6
{
	public class Character
	{
		private string name;
		private int hp; //текущее колво здоровья
		private int maxHealth;
		private int energy; //текущее колво энергии
		private int maxEnergy;
		private int coins;
		private Weapon weapon;
		private Armor armor;
		private MagicRing ring;
        public Inventory inventory;




        public Character(string name, int maxHealth,int maxEnergy, Inventory inventory)
		{
			this.name = name;
			this.maxEnergy = maxEnergy;
			this.maxHealth = maxHealth;
            this.inventory = inventory;
		}

		public void AddHealth(int value)
		{
			
				hp += value;
			
			if(hp>maxHealth)
			{
				hp = maxHealth;
			}
			if(hp<0)
			{
				hp = 0;
			}
		}

        public void AddEnergy(int value)
        {
           
            
                energy += value;
            
            
            if (energy > maxEnergy)
            {
                hp = maxEnergy;
            }
            if (energy < 0)
            {
                energy = 0;
            }
        }

		public void AddGold(int value)
		{
            if (value >= 0)
            {
                coins += value;
            }
            else if (value < 0)
            {
                coins -= value;
            }
			if(coins<0)
			{
				coins = 0;
			}
        }

		public void EquipWeapon(Weapon weapon)
		{
            this.weapon = weapon;
            Console.WriteLine($"Экипировано оружие: {weapon.Name}");
        }

		public void EquipArmor(Armor armor)
		{
            this.armor = armor;
            Console.WriteLine($"Экипирована броня: {armor.Name}");
        }

        public void EquipRing(MagicRing ring)
        {
            this.ring = ring;
            Console.WriteLine($"Экипировано кольцо: {ring.Name}");
        }


        public void UnequipWeapon(Weapon weapon)
		{
            if (weapon != null)
            {
                Console.WriteLine($"Снято оружие: {weapon.Name}");
                weapon = null;
            }
        }

		public void UnequipArmor(Armor armor)
		{
            if (armor != null)
            {
                Console.WriteLine($"Снята броня: {armor.Name}");
                armor = null;
            }
        }

        public void UnequipRing(MagicRing ring)
        {
            if (ring != null)
            {
                Console.WriteLine($"Снято кольцо: {ring.Name}");
                ring = null;
            }
        }

        //public void Udalenie(Item item)
        //{
        //    if (item != null)
        //    {
        //        Console.WriteLine($"Предмет удален: {item.Name}");
        //        item = null;
        //    }
        //}

        public void ShowInfo()
		{
			Console.WriteLine(name);
            Console.WriteLine($"{hp}/{maxHealth} hp");
            Console.WriteLine($"{energy}/{maxEnergy} единиц энергии");
            Console.WriteLine($"{coins} денег");
            Console.WriteLine();

        }










    }
}


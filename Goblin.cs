using System;
namespace magic
{
	public class Goblin : Character
	{
		public Goblin(string name, int health,int maxhealth): base(name,health,maxhealth)
		{
			this.name = name;
			this.health = health;
			this.maxhealth = maxhealth;

		}

        public override void Damage(int damage)
        {
            base.Damage(damage-1);
        }

		public void GoblinPunch(Character character)
		{
			Random random = new Random();
			int damage = random.Next(1, 11);
			Console.WriteLine($"{Name} атакует {character.Name} и наносит {damage} урона");
			character.Damage(damage);
		}
    }
}


using System;
using System.Collections.Generic;
namespace magic
{
	public abstract class Character
	{
		protected string name;
		protected int health;
		protected int maxhealth;
		protected bool isDead = false;
        protected System.Collections.Generic.List<Effect> activeEffects;

        public string Name { get { return name; } }
		public int Health{get{return health;}}
		public int Maxhealth { get { return maxhealth; } }
		public bool IsDead { get { return isDead; } }



		public Character(string name,int health, int maxhealth)
		{
			this.name = name;
			this.health = health;
			this.maxhealth = maxhealth;
			this.activeEffects = new List<Effect>();
		}

        public void DisplayEffects()
        {
            if (activeEffects.Count > 0)
            {
                Console.WriteLine($"Активные эффекты {name}:");
                for (int i = 0; i < activeEffects.Count; i++)
                {
                    Console.WriteLine($"{activeEffects[i].Name} (ходов: {activeEffects[i].Duration})");
                }
            }
            else
            {
                Console.WriteLine($"{name} не имеет активных эффектов");
            }
        }

		public void ProcessEffect()
		{
			List<Effect> processEffects = new List<Effect>();
			for(int i=0; i<activeEffects.Count;i++)
			{
				processEffects.Add(activeEffects[i]);
			}

            for (int i = 0; i <processEffects.Count; i++)
			{
				Effect effect = processEffects[i];
				if(effect.Duration>0)
				{
					effect.Turn(this);
					effect.DurationTime();
				}
			}

			for(int i =activeEffects.Count-1; i>=0;i--)
			{
				if (activeEffects[i].Duration<=0)
				{
					activeEffects[i].End(this);
					activeEffects.RemoveAt(i);

				}
			}


        }
        public void DisplayStatus()
        {
            Console.WriteLine($"{name}: {health}/{maxhealth} HP");
        }


        public void AddEffect(Effect effect)
		{
			activeEffects.Add(effect);
			effect.Apply(this);
		}
		public virtual void Damage(int damage)
		{
            for (int i = 0; i < activeEffects.Count; i++)
            {
                Effect effect = activeEffects[i];
                if (effect is Shielded shielded)
                {
                    damage = shielded.Protection(damage);
                }
            }

            health -= damage;
			
			if(health<=0)
			{
				health = 0;
				isDead = true;
				Console.WriteLine($"{name} умер");
			}
            BatlleJournal.AddDamage($"{name} получает {damage} урона. Здоровье: {health}/{maxhealth}");
        }

        public virtual void Regeneration(int hp)
		{
			health += hp;
			if (health>maxhealth)
			{
				health = maxhealth;
			}
            BatlleJournal.AddHeal($"{name} восстанавливает {hp} здоровья. Здоровье: {health}/{maxhealth}");
        }
	}
}


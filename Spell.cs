using System;
namespace magic
{
	public abstract class Spell
	{
		protected string name;
		protected string description;

        protected int cooldown;          
        protected int currentCooldown;

        public int CurrentCooldown { get { return currentCooldown; } }
        public bool IsReady { get { return currentCooldown <= 0; } }


        public string Name { get { return name; } }
		public string Description { get { return description; } }

		public Spell(string name, string description,int cooldown)
		{
			this.name = name;
			this.description = description;
            this.cooldown = cooldown;
            this.currentCooldown = 0;
        }

		public abstract void SpellCast(Character character);
		

		public  virtual void SpellInfo()
		{
			Console.WriteLine(name);
			Console.WriteLine(description);
            if (currentCooldown > 0)
            {
                Console.Write($" [Перезарядка: {currentCooldown}]");
            }
        }

        public void StartCooldown()
        {
            currentCooldown = cooldown;
        }

        public void ReduceCooldown()
        {
            if (currentCooldown > 0)
            {
                currentCooldown--;
            }
        }



    }
}


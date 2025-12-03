using System;
namespace magic
{
	public class Shielded : Effect
	{
        private int protection;
		public Shielded(int duration = 3, int protection = 3) : base("Защита",duration)
		{
            this.protection = protection;
		}

        public override void Apply(Character character)
        {
            Console.WriteLine($"{character.Name} получает щит");
        }

            
        public override void Turn(Character character)
        {
            Console.WriteLine($"{character.Name} защищен щитом, осталось {duration-1} ходов");
        }

        public override void End(Character character)
        {
            Console.WriteLine($"Щит {character.Name} сломался");
        }

        public int Protection(int incomingDamage)
        {
            int newDamage =  Math.Max(0, incomingDamage - protection);
            Console.WriteLine($"Щит поглотил {protection} урона");
            return newDamage;
        }
    } 
}


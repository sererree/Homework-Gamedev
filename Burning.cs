using System;
namespace magic
{
	public class Burning : Effect
	{
        private int DamageBurning;

		public Burning( int duration=2,int DamageBurning = 2) : base("Горение", duration)
		{
            this.DamageBurning = DamageBurning;
		}

        public override void Apply(Character character)
        {
            Console.WriteLine($"{character.Name} загорелся");


        }

        public override void Turn(Character character)
        {
            if(character.IsDead == false)
            {
                Console.WriteLine($"{character.Name} горит и получает {DamageBurning} урона");
                BatlleJournal.AddEffect($"{character.Name} горит и получает {DamageBurning} урона");
                character.Damage(DamageBurning);
            }
        }
        public override void End(Character character)
        {
            Console.WriteLine($"{character.Name} больше не горит");
        }
    }
}


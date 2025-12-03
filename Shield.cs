using System;
namespace magic
{
	public class Shield : Spell
	{
        private int protection;
        private int duration;
		public Shield(int protection = 3, int duration = 2, int cooldown = 2) : base("Щит", "Дает временную защиту",cooldown)
		{
            this.protection = protection;
            this.duration = duration;
		}
        public override void SpellCast(Character character)
        {
          
            Shielded shielded = new Shielded(duration,protection);
            shielded.Apply(character);
            character.AddEffect(shielded);

        }

        public override void SpellInfo()
        {
            base.SpellInfo();
        }
    }
}


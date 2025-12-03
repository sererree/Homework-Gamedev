using System;
namespace magic
{
	public class Heal : Spell
	{
        private int hp;
        public Heal(int hp = 5, int cooldown = 3) : base("Регенерация", "Восстанавливает 5 здоровья",cooldown)
		{
            this.hp = hp;
		}

        public override void SpellCast(Character character)
        {
            Console.WriteLine($"{character.Name} восстановил {hp} здоровья");
            character.Regeneration(hp);
            StartCooldown();
        }

        public override void SpellInfo()
        {
            base.SpellInfo();
        }
    }
}


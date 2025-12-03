using System;
namespace magic
{
	public class Mage : Character
	{
        public List<Spell> spells;
        public Mage(string name,int health, int maxhealth) : base(name,health,maxhealth)
		{
			this.name = name;
			this.health = health;
			this.maxhealth = maxhealth;
			spells = new List<Spell>();
			HelpSpells();

		}

		private void HelpSpells()
		{
			spells.Add(new Fireball());
			spells.Add(new Heal());
			spells.Add(new Shield());
		}

		public void SpellCuster(int number, Character character)
		{

			if (number < 1 || number > spells.Count)
			{
				Console.WriteLine("Такого нет");
			}
            Spell ChoiceSpell = spells[number - 1];
            
            Console.WriteLine($"{Name} использует {ChoiceSpell.Name} на {character.Name}!");
            BatlleJournal.AddAction($"{Name} использует {ChoiceSpell.Name} на {character.Name}!");
            if (!ChoiceSpell.IsReady)
            {
                BatlleJournal.AddAction($"{Name} пытается использовать {ChoiceSpell.Name}, но оно на перезарядке! Осталось: {ChoiceSpell.CurrentCooldown}");
                return;
            }

            ChoiceSpell.SpellCast(character);
		}

        public void ReduceCooldowns()
        {
            for (int i=0; i<spells.Count;i++)
            {
				spells[i].ReduceCooldown();
            }
        }


        public void ShowBook()
		{
            Console.WriteLine($"Книга заклинаний {Name}:");
            for (int i = 0; i < spells.Count; i++)
            {

                Console.Write($"{i + 1}. ");
                spells[i].SpellInfo();
                Console.WriteLine();
            }
        }

	}
}


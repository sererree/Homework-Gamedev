using System;
namespace magic
{
	public class Battle
	{

		private Mage mage;
		private Goblin goblin;
		private int round;
		private Random random;

		public Battle(Mage mage, Goblin goblin)
		{
			this.mage = mage;
			this.goblin = goblin;
            random = new Random();
			round = 1;
		}




		public void StartBattle()
		{
            while (mage.IsDead == false && goblin.IsDead == false)
            {
                ThisRound();
                round++;
            }

			EndBattle();
        }

		private void ThisRound()
		{
            BatlleJournal.StartRound(round);
            Console.WriteLine($"Раунд{round}");
			Console.WriteLine($"Ход {mage.Name}");
			MagePunch();
			ProcessEffects();
            ProcessCooldowns();
            ShowStatus();

            Console.WriteLine($"Ход {goblin.Name}");
			goblin.GoblinPunch(mage);
			ProcessEffects();
			ShowStatus();
        }


		private void EndBattle()
		{
			Console.WriteLine("Конец боя");

			if(mage.IsDead)
			{
				Character winner = goblin;
                Character loser = mage;
                Console.WriteLine($"{mage.Name} мертв, победил {goblin.Name}");
                BatlleJournal.ConsoleBattleReport(winner, loser);
            }
			if(goblin.IsDead)
			{
                Character winner = mage;
                Character loser = goblin;
				Console.WriteLine($"{goblin.Name} мертв, победил {mage.Name}");
                BatlleJournal.ConsoleBattleReport(winner, loser);
            }
			
		}
		private void MagePunch()
		{
            Console.WriteLine($"Здоровье {mage.Name}: {mage.Health}/{mage.Maxhealth}");
            Console.WriteLine($"Здоровье {goblin.Name}: {goblin.Health}/{goblin.Maxhealth}");

			int spellnumber = InputSpell();
			Character target = Target();
			mage.SpellCuster(spellnumber, target);

        }

        private void ProcessCooldowns()
        {
            mage.ReduceCooldowns();
        }

        private int InputSpell()
		{

				Console.WriteLine("Выберите заклинание");
				mage.ShowBook();
			while(true)
			{
                int input = IntInput();
                Spell selectedSpell = mage.spells[input - 1];
                if (input >= 1 && input <= 3)
                {
                    if (selectedSpell.IsReady)
                    {
                        return input;
                    }
                    else
                    {
                        Console.WriteLine($"Заклинание {selectedSpell.Name} на перезарядке! Осталось: {selectedSpell.CurrentCooldown} ходов");
                        Console.WriteLine("Выберите другое заклинание...");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный номер заклинания! Введите число от 1 до 3.");
                }
            }
        }
				

		private Character Target()
		{
			
				
			Console.WriteLine("Выберите цель");
            Console.WriteLine($"1.{mage.Name} 2.{goblin.Name}");
            while (true)
            {
                int input = IntInput();
                if (input >= 1 && input <= 2)
                {
                    if (input == 1)
                    {
                        return mage;
                    }
                    if (input == 2)
                    {
                        return goblin;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный номер цели! Введите число от 1 до 2.");
                }
            }

          
			

			
		}

        private void ProcessEffects()
        {
            mage.ProcessEffect();
            goblin.ProcessEffect();
        }




        public void ShowStatus()
        {

            mage.DisplayStatus();
            goblin.DisplayStatus();
            Console.WriteLine();
        }

        private int IntInput()
		{
			Console.WriteLine("Введите целое число");
			if (int.TryParse(Console.ReadLine(), out int number))
			{
				return number;
			}
			else
			{
				Console.WriteLine("Введен неверный формат числа");
			}
			return 0;
		}
	}
}


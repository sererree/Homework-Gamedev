using System;
namespace sr2
{
	public class GameManager
	{
		private Settlement settlement;
		private int gameTime;
		//public Settlement Settlement { get { return settlement; } }
		public GameManager(int gameTime, Settlement settlement)
		{
			this.gameTime = gameTime;
			this.settlement = settlement;
		}

		public void SimulateProduction()
		{
			int summa = 0;
			
			for (int i = 0; i<settlement.Buildings.Length; i++)
			{
				if (settlement.Buildings[i] != null)
				{
					summa += settlement.Buildings[i].Production * gameTime;

                }
			}
			Console.WriteLine($"Поселение производит {summa} ресурсов ");
		}
	}
}


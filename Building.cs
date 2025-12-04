using System;
namespace sr2
{
	public class Building
	{

		private string name;
		private int buildCost;
		private int production;

		public string Name { get { return name; } }
		public int BuildCost { get { return buildCost; } }
		public int Production { get { return production; } }


		public Building(string name, int buildCost, int production)
		{
			this.name = name;
			this.buildCost = buildCost;
			this.production = production;
		}

		public void DisplayInfo()
		{
			Console.WriteLine($"Название {name}, Стоимость {buildCost}, Производство в минуту {production}");
		}

	}
}



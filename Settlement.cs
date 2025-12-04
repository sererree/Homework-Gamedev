using System;
namespace sr2
{
	public class Settlement
	{
		private Building[] buildings = new Building[5];
		private int mesta = 5;
		private int budget;

		public int Budget { get { return budget; } }
		public Building[] Buildings { get { return buildings; } }
		public Settlement(int budget)
		{
			this.budget = budget;
		}

		public void AddBuilding(Building building)
		{
			if(mesta <= 0)
			{
				Console.WriteLine("Недостаточно мест");
            }
            if (budget < building.BuildCost)
            {
                Console.WriteLine("Недостаточно денег");
            }

            for(int i =0;i<buildings.Length;i++)
			{
				if (buildings[i] == null && budget >= building.BuildCost && mesta>0)
				{
                    buildings[i] = building;
                    budget -= building.BuildCost;
                    mesta--;
					break;
                }
			}
        	
		}

		public int GetTotalProdaction()
		{
			int prodaction = 0;
			for(int i =0; i<buildings.Length;i++)
			{
				if (buildings[i] != null)
				{
                    prodaction += buildings[i].Production;
                }
				
			}
			return prodaction;
		}


		public void ShowBuildings()
		{
            for (int i = 0; i < buildings.Length; i++)
            {
                if (buildings[i] != null)
                {
					buildings[i].DisplayInfo();
                }
				
            }
        }
	}


}


using System;
using sr2;

internal class Program
{
    static void Main(string[] args)
    {
        Building KFU = new Building("KFU", 5, 10);
        Building ITIS = new Building("ITIS", 3, 8);
        Building[] buildings = new Building[2] { KFU, ITIS };
        for(int i=0; i<buildings.Length; i++)
        {
            buildings[i].DisplayInfo();
        }


        Building Dorogo = new Building("Дорого", 100, 1);
        Settlement settlement = new Settlement(10);
        settlement.AddBuilding(KFU);
        settlement.AddBuilding(ITIS);
        settlement.AddBuilding(Dorogo);
        Console.WriteLine("Общая производительность " + settlement.GetTotalProdaction());
        settlement.ShowBuildings();



        Settlement Zdania = new Settlement(100);
        GameManager gameManager = new GameManager(10, Zdania);
        Zdania.AddBuilding(KFU);
        Zdania.AddBuilding(ITIS);
        Zdania.ShowBuildings();
        gameManager.SimulateProduction();
       

    }
}


using System;
using System.IO;
using System.Threading.Tasks;
using kr;

internal class Program
{
    static async Task Main(string[] args)
    {

        string filePath = "quests.txt";

        PrepareTestData(filePath);

         
        Hranilische<InfoQuest> hranilische = new Hranilische<InfoQuest>();

        hranilische.LoadItem += (quest) => Console.WriteLine($"Загружен квест {quest}");
        hranilische.SelectItem += (quest) => Console.WriteLine($"Выбран квест {quest}");

        Console.WriteLine($"Загрузка из {filePath}");
        await LoadQuest(filePath, hranilische);
        Console.WriteLine("Загружено");


        Console.WriteLine("активные квесты");

        var activeQuests = new ActiveQuestFilter();
        var activeQuestsFil = hranilische.Filter(activeQuests);


        foreach(var quest in activeQuestsFil)
        {
            Console.WriteLine("Активный квест");

        }

        Console.WriteLine("Дорогие квсеты");
        var richFilter = new RichQuestFilter();
        var richFilterFil = hranilische.Filter(richFilter);



        foreach (var quest in richFilterFil)
        {
            Console.WriteLine("Дорогой квест");

        }



    }

   




    static async Task LoadQuest(string path, Hranilische<InfoQuest> hranilische)
    {

        if (!File.Exists(path)) return;

       using (StreamReader reader = new StreamReader(path))
        {
            string line;

            while((line = await reader.ReadLineAsync()) != null )
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(';');
                if(parts.Length == 3)
                {
                    string name = parts[0];

                    if (Enum.TryParse(parts[1], out QuestStatus status) && int.TryParse(parts[2], out int nagrada))
                    {
                        InfoQuest quest = new InfoQuest(name, status, nagrada);
                        hranilische.Add(quest);
                    }

                }
            }


        }
    }

    static void PrepareTestData(string path)
    {
        string napolnenie = "Find Sword;Active;100\n" +
            "Defeat Boss;Locked;500\n" +
            "Talk to NPC;Completed;50\n" +
            "Collect;Active;30\n" +
            "Save Village;Active;500\n";
        File.WriteAllText(path, napolnenie);
    }


}


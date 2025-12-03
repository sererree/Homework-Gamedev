using System;
namespace magic
{
    public static class BatlleJournal
    {
        private static List<string> journal = new List<string>();
        private static int roundNumber;

        public static void StartRound(int round)
        {
            roundNumber = round;
            AddString($"Раунд {round}");
        }


        public static void AddEffect(string effect)
        {
            AddString($"Эффект {effect}");
        }
        public static void AddAction(string action)
        {
            AddString($"Действие {action}");
        }
        public static void AddStatus(string status)
        {
            AddString($"Статус {status}");
        }
        public static void AddDamage(string damageInfo)
        {
            AddString($"Урон {damageInfo}");
        }
        public static void AddHeal(string healInfo)
        {
            AddString($"Лечение {healInfo}");
        }

        private static void AddString(string action)
        {
            string roundAction = $"Раунд {roundNumber}: {action}";
            journal.Add(roundAction);
        }


        public static void ConsoleBattleReport(Character winner, Character loser)
        {
            Console.WriteLine("Журнал боя");
            for (int i = 0; i < journal.Count; i++)
            {
                Console.WriteLine(journal[i]);
            }
            Console.WriteLine("Конец боя");
            Console.WriteLine($"Победитель: {winner.Name}");
            Console.WriteLine($"Проигравший: {loser.Name}");
            Console.WriteLine($"Всего раундов: {roundNumber}");
        }
    }

}
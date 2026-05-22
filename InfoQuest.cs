using System;
namespace kr
{
	public class InfoQuest
	{
		public string Name { get; set; }
        public int Nagrada { get; set; }
        public QuestStatus QuestStatus { get; set; }

		public InfoQuest(string name, QuestStatus questStatus, int nagrada)
		{
			Name = name;
			QuestStatus = questStatus;
			Nagrada = nagrada;
		}

        public override string ToString()
        {
			return $"{Name} | {QuestStatus} | {Nagrada}";
        }
    }
}


using System;

namespace kr
{
	public class ActiveQuestFilter : IFilter<InfoQuest>
	{
		public ActiveQuestFilter()
		{

		}

        public bool Check(InfoQuest item)
        {
            return item.QuestStatus == QuestStatus.Active;
        }
    }

}

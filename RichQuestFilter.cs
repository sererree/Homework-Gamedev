using System;
namespace kr
{
	public class RichQuestFilter : IFilter<InfoQuest>
	{
		public RichQuestFilter()
		{
		}

        public bool Check(InfoQuest item)
        {
            return item.Nagrada >= 200;
        }

        public interface IFilter<T>
        {

        }
    }
}


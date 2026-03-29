using System;
namespace DZ2_sem2
{
	public interface IJournalEntry
	{
		string ToLogLine();
		string ToScreenLine();
	}
}


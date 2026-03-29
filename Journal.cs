using System;
namespace DZ2_sem2
{
	internal class Journal<T> where T: IJournalEntry
	{
		public Journal()
		{
		}

        private readonly List<T> entries = new List<T>();
        public void Add(T entry)
        {
            entries.Add(entry);
        }

        public List<T> GetAll()
        {
            return entries;
        }

        public void SaveToFile(string path)
        {
            List<string> lines = new List<string>();
            foreach (var entry in entries)
            {
                lines.Add(entry.ToLogLine());
            }
            File.WriteAllLines(path, lines);
        }

    }
}


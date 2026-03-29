using System;
namespace DZ2_sem2
{
	public class MovedEvent : IJournalEntry
	{
        public string ProductName { get; set; }
        public string FromShelf { get; set; }
        public int FromSlot { get; set; }
        public string ToShelf { get; set; }
        public int ToSlot { get; set; }

        public string ToLogLine() => $"MOVED|{ProductName}|{FromShelf}|{FromSlot}|{ToShelf}|{ToSlot}";
        public string ToScreenLine() => $"[Перенос] Товар '{ProductName}' перенесён с {FromShelf}:{FromSlot} на {ToShelf}:{ToSlot}";
        public static MovedEvent FromLogLine(string line)
        {
            string[] parts = line.Split('|');
            return new MovedEvent
            {
                ProductName = parts[1],
                FromShelf = parts[2],
                FromSlot = int.Parse(parts[3]),
                ToShelf = parts[4],
                ToSlot = int.Parse(parts[5])
            };
        }
    }

}


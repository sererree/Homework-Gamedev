using System;
namespace DZ2_sem2
{
    internal class PlacedEvent : IJournalEntry
    {
        public string ProductName { get; set; }
        public string Shelf { get; set; }
        public int Slot { get; set; }
        public string ToLogLine() => $"PLACED|{ProductName}|{Shelf}|{Slot}";
        public string ToScreenLine() => $"[Размещение] Товар '{ProductName}' положен на полку {Shelf}, слот {Slot}";

        public static PlacedEvent FromLogLine(string line)
        {
            string[] parts = line.Split('|');
            return new PlacedEvent { ProductName = parts[1], Shelf = parts[2], Slot = int.Parse(parts[3]) };
        }
    }
}


using System;
using DZ2_sem2;

namespace DZ2_sem2
{
    internal class TakenEvent : IJournalEntry
    {
        public string ProductName { get; set; }
        public string Shelf { get; set; }
        public int Slot { get; set; }
        public string ToLogLine() => $"TAKEN|{ProductName}|{Shelf}|{Slot}";
        public string ToScreenLine() => $"[Изъятие] Товар '{ProductName}' взят с полки {Shelf}, слот {Slot}";

        public static TakenEvent FromLogLine(string line)
        {
            string[] parts = line.Split('|');
            return new TakenEvent { ProductName = parts[1], Shelf = parts[2], Slot = int.Parse(parts[3]) };
        }
    }

}


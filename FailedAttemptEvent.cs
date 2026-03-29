using System;
namespace DZ2_sem2
{
    internal class FailedAttemptEvent : IJournalEntry
    {
        public string Operation { get; set; }  
        public string Shelf { get; set; }      
        public int? Slot { get; set; }         
        public string Reason { get; set; }     

        public string ToLogLine() => $"FAILED|{Operation}|{Shelf}|{Slot}|{Reason}";

        public string ToScreenLine() => $"[Ошибка] {Operation} | полка {Shelf} слот {Slot} | {Reason}";

      
        public static FailedAttemptEvent FromLogLine(string line)
        {
            string[] parts = line.Split('|');
            string operation = parts[1];
            string shelf = parts[2];
            int? slot = parts[3] == "" ? null : int.Parse(parts[3]);
            string reason = parts[4];

            return new FailedAttemptEvent
            {
                Operation = operation,
                Shelf = shelf,
                Slot = slot,
                Reason = reason
            };
        }
    }
}


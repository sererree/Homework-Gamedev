using System;
using System.Collections.Generic;
using System.IO;
using DZ2_sem2;

internal class Program
{
    const int S = 5;
    private const string PlacedLogFile = "placed.log";
    private const string TakenLogFile = "taken.log";
    private const string MovedLogFile = "moved.log";
    private const string FailedLogFile = "failed.log";

    private static Shelf shelfA;
    private static Shelf shelfB;
    private static Journal<PlacedEvent> placedJournal;
    private static Journal<TakenEvent> takenJournal;
    private static Journal<MovedEvent> movedJournal;
    private static Journal<FailedAttemptEvent> failedJournal;

    static void Main(string[] args)
    {
        shelfA = new Shelf("A", S);
        shelfB = new Shelf("B", S);
        placedJournal = new Journal<PlacedEvent>();
        takenJournal = new Journal<TakenEvent>();
        movedJournal = new Journal<MovedEvent>();
        failedJournal = new Journal<FailedAttemptEvent>();
        LoadState();

        while (true)
        {
            Console.WriteLine($"\nПолка A: {GetShelfStr(shelfA)}");
            Console.WriteLine($"Полка B: {GetShelfStr(shelfB)}");

            Console.WriteLine("\n1 - Положить\n2 - Забрать\n3 - Перенести\n4 - Журналы\n5 - Выход");

            int choice = intinput();

            if (choice == 1) PutProduct();
            else if (choice == 2) TakeProduct();
            else if (choice == 3) MoveProduct();
            else if (choice == 4) ShowJournals();
            else if (choice == 5) { SaveAndExit(); break; }
            else Console.WriteLine("Неверный ввод");
        }

        
    }

    static Shelf GetShelfByName(string name)
    {
        name = name.Trim().ToUpper();
        if (name == "A" || name == "А") return shelfA; 
        if (name == "B" || name == "В") return shelfB;
        return null;
    }

    static string GetShelfStr(Shelf shelf)
    {
        string result = "";
        for (int i = 1; i <= S; i++)
        {
            string val = shelf.Read(i);
            result += $"[{i}]{(val == null ? "пусто" : val)} ";
        }
        return result;
    }

    static void PutProduct()
    {
        Console.Write("Полка (A/B): ");
        string shelfName = Console.ReadLine();
        Shelf shelf = GetShelfByName(shelfName);

        if (shelf == null) { Console.WriteLine("Ошибка: Полка не найдена"); return; }
        Console.Write("Слот (1-5): ");
        int slot = intinput();
        Console.Write("Товар: ");
        string product = Console.ReadLine();

        
        if (shelf.Put(slot, product))
        {
            placedJournal.Add(new PlacedEvent { ProductName = product, Shelf = shelfName, Slot = slot });
            Console.WriteLine("Готово");
        }
        else
        {
            Console.WriteLine("Слот занят");
            failedJournal.Add(new FailedAttemptEvent
            {
                Operation = "Положить",
                Shelf = shelfName,
                Slot = slot,
                Reason = "слот занят"
            });
        }
    }

    static void TakeProduct()
    {
        Console.Write("Полка (A/B): ");
        Shelf shelf = GetShelfByName(Console.ReadLine());
        if (shelf == null) return;

        Console.Write("Слот (1-5): ");
        int slot = intinput();
        string product = shelf.Take(slot);

        if (product != null)
        {
            takenJournal.Add(new TakenEvent { ProductName = product, Shelf = shelf.Name, Slot = slot });
            Console.WriteLine($"Взято: {product}");
        }
        else
        {
            Console.WriteLine("Ошибка: слот пуст");
            failedJournal.Add(new FailedAttemptEvent { Operation = "Забрать", Shelf = shelf.Name, Slot = slot, Reason = "пусто" });
        }
    }

    static void MoveProduct()
    {
        Console.Write("Откуда полка (A/B): ");
        Shelf fromShelf = GetShelfByName(Console.ReadLine());
        if (fromShelf == null) { Console.WriteLine("Ошибка: Полка-источник не найдена"); return; }

        Console.Write("Откуда слот (1-5): ");
        int fromSlot = intinput();

        Console.Write("Куда полка (A/B): ");
        Shelf toShelf = GetShelfByName(Console.ReadLine());
        if (toShelf == null) { Console.WriteLine("Ошибка: Полка-назначение не найдена"); return; }

        Console.Write("Куда слот (1-5): ");
        int toSlot = intinput();

        
        string product = fromShelf.Read(fromSlot);

        if (product == null)
        {
            Console.WriteLine("Ошибка: Слот-источник пуст.");
            failedJournal.Add(new FailedAttemptEvent
            {
                Operation = "Перенести",
                Shelf = fromShelf.Name,
                Slot = fromSlot,
                Reason = "пусто"
            });
            return;
        }

        
        if (toShelf.Put(toSlot, product))
        {
          
            fromShelf.Take(fromSlot);
            movedJournal.Add(new MovedEvent
            {
                ProductName = product,
                FromShelf = fromShelf.Name,
                FromSlot = fromSlot,
                ToShelf = toShelf.Name,
                ToSlot = toSlot
            });
            Console.WriteLine($"Успешно перенесено: {product}");
        }
        else
        {
           
            Console.WriteLine("Ошибка: Слот назначения занят или неверен.");
            failedJournal.Add(new FailedAttemptEvent
            {
                Operation = "Перенести",
                Shelf = toShelf.Name,
                Slot = toSlot,
                Reason = "занято"
            });
        }
    }

    static void ShowJournals()
    {
        Console.WriteLine("\n--- Размещения ---");
        foreach (var e in placedJournal.GetAll()) Console.WriteLine(e.ToScreenLine());

        Console.WriteLine("\n--- Изъятия ---");
        foreach (var e in takenJournal.GetAll()) Console.WriteLine(e.ToScreenLine());

        Console.WriteLine("\n--- Переносы ---");
        foreach (var e in movedJournal.GetAll()) Console.WriteLine(e.ToScreenLine());

        Console.WriteLine("\n--- Неудачные попытки ---");
        foreach (var e in failedJournal.GetAll()) Console.WriteLine(e.ToScreenLine());
    }

    static void SaveAndExit()
    {
        placedJournal.SaveToFile(PlacedLogFile);
        takenJournal.SaveToFile(TakenLogFile);
        movedJournal.SaveToFile(MovedLogFile);
        failedJournal.SaveToFile(FailedLogFile);
        Console.WriteLine("Все журналы сохранены.");
    }

    static void LoadState()
    {
        
        if (File.Exists(PlacedLogFile))
        {
            foreach (var line in File.ReadAllLines(PlacedLogFile))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var ev = PlacedEvent.FromLogLine(line);
                placedJournal.Add(ev);
                GetShelfByName(ev.Shelf)?.Put(ev.Slot, ev.ProductName);
            }
        }

        
        if (File.Exists(MovedLogFile))
        {
            foreach (var line in File.ReadAllLines(MovedLogFile))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var ev = MovedEvent.FromLogLine(line);
                movedJournal.Add(ev);
                GetShelfByName(ev.FromShelf)?.Take(ev.FromSlot);
                GetShelfByName(ev.ToShelf)?.Put(ev.ToSlot, ev.ProductName);
            }
        }

        if (File.Exists(TakenLogFile))
        {
            foreach (var line in File.ReadAllLines(TakenLogFile))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var ev = TakenEvent.FromLogLine(line);
                takenJournal.Add(ev);
                GetShelfByName(ev.Shelf)?.Take(ev.Slot);
            }
        }

        if (File.Exists(FailedLogFile))
        {
            foreach (var line in File.ReadAllLines(FailedLogFile))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                failedJournal.Add(FailedAttemptEvent.FromLogLine(line));
            }
        }
    }


    static int intinput()
    {
        while (true)
        {
            Console.WriteLine("Введите целое число");
            if (int.TryParse(Console.ReadLine(), out int intnumber))
            {
                return intnumber;
            }
            else
            {
                Console.WriteLine("Неверный формат числа");
            }
        }
    }

}


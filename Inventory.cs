using System;
namespace dz6
{
	public class Inventory
	{

        private List<Item> items;
        private int maxItems;
        public Inventory(int maxSize)
        {
            items = new List<Item>();
            maxItems = maxSize;
        }

        public bool AddItem(Item item)
        {

            if (item is IStackable newStackable)
            {
   
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i] is IStackable existingStackable && items[i].GetType() == item.GetType() && items[i].Name == item.Name)
                    {
                        
                        existingStackable.AddOne();
                       
                        return true;
                    }
                }
            }
            if (items.Count < maxItems)
            {
                items.Add(item);
                Console.WriteLine($"Предмет {item.Name} добавлен в инвентарь");
                return true;
            }
            else
            {
                Console.WriteLine("Инвентарь заполнен. Нельзя добавить предмет.");
                return false;
            }
        }

            public bool RemoveAt(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                Item removedItem = items[index];
                items.RemoveAt(index);
                Console.WriteLine($"Предмет {removedItem.Name} удален из инвентаря");
                return true;
            }
            else
            {
                Console.WriteLine("Неверный индекс предмета");
                return false;
            }
        }

        public Item GetItem(int index)
        {
            if (index >= 0 && index < items.Count)
            {
                return items[index];
            }
            else
            {
                Console.WriteLine("Неверный индекс предмета");
                return null;
            }
        }

        public void ShowInventory()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Инвентарь пуст");
            }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i] is IStackable stackable)
                    {
                        
                        Console.WriteLine($"[{i}] {items[i].Name} x{stackable.Count} - {items[i].Description}");
                    }
                    else
                    {
                        Console.WriteLine($"[{i}] {items[i].Name} - {items[i].Description}");
                    }
                    
                }
            }
        }
    }
}


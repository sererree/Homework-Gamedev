using System;
namespace oop_nachalo
{
    public class PlayerInventory
    {
        private Item[] items = new Item[5];
        private float weightCapacity = 50f;
        private float inventoryWeight;
        private float inventoryPrice;

        public PlayerInventory(float weightCapacity, Item[] items)
        {
            this.weightCapacity = weightCapacity;
            this.items = items;
        }

        public Item[] Items
        {
            get
            {
                return items;
            }
        }
        public float WeightCapacity
        {
            get
            {
                return weightCapacity;
            }
        }
        public float InventoryPrice
        {
            get
            {
                return inventoryPrice;
            }
        }
        public float InventoryWeight
        {
            get
            {
                return inventoryWeight;
            }
        }


        public void AddItem(Item item)
        {

            if (item.Weight > weightCapacity)
            {
                Console.WriteLine("Инвентарь не может вместить данный предмет");
                return;
            }

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null && item.Weight < weightCapacity)
                {
                    items[i] = item;
                    weightCapacity -= item.Weight;
                    Console.WriteLine("Предмет добавлен");
                    inventoryWeight += item.Weight;
                    inventoryPrice += item.Price;
                    return;
                }



            }
            Console.WriteLine("Инвентарь полон");





        }


        public void ShowInventory()
        {
            for (int i = 0; i < 5; i++)
            {
                if (Items[i] != null)
                {
                    Items[i].DisplayInfo();
                }



            }
        }

        public void GetTotalWeight()
        {
            Console.WriteLine($"Вес всех вещей {inventoryWeight}");
        }

        public void GetTotalPrice()
        {
            Console.WriteLine($"Цена всех вещей: {inventoryPrice}");
        }
    }
}


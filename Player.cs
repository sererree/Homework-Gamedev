using System;
namespace oop_nachalo
{
    public class Player
    {
        private string name;
        private PlayerInventory inventory;

        public PlayerInventory Inventory
        {
            get
            {
                return inventory;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Player(string name, PlayerInventory inventory)
        {
            this.name = name;
            this.inventory = inventory;
        }

        public void PickUpItem(Item item)
        {
            inventory.AddItem(item);
        }


        public void ShowInventory()
        {
            inventory.ShowInventory();
        }

        public void GetInventoryValue()
        {
            inventory.GetTotalPrice();
        }

    }
}


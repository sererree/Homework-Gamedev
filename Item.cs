using System;
namespace oop_nachalo
{
    public class Item
    {
        private string name;
        private int price;
        private float weight;

        public Item(string name, int price, float weight)
        {
            this.name = name;
            this.price = price;
            this.weight = weight;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
        }

        public float Weight
        {
            get
            {
                return weight;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Предмет: {name}, Цена: {price}, Вес: {weight}");
        }




    }
}


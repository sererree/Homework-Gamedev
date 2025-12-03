using System;
using dz6;

internal class Program
{
    static void Main(string[] args)
    {

        var inventory = new Inventory(10);
        var user = new Character("Кот", 100, 50, inventory);
        inventory.AddItem(new HealthPotion());
        inventory.AddItem(new HealthPotion());
        inventory.AddItem(new Food());
        inventory.AddItem(new Gem());
        inventory.AddItem(new OldBoot());
        inventory.AddItem(new Weapon());
        inventory.AddItem(new Armor());
        inventory.AddItem(new MagicRing());
        inventory.AddItem(new Scroll());




        while (true)
        {

            user.ShowInfo();
            inventory.ShowInventory();
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Использовать предмет");
            Console.WriteLine("2 - Экипировать предмет");
            Console.WriteLine("3 - Продать предмет");
            Console.WriteLine("4 - Выбросить предмет");
            Console.WriteLine("0 - Выход");


            string input = IntInput();

            if (input == "0")
            {
                break;
            }
            if (int.TryParse(input, out int action) && action >= 1 && action <= 4)
            {
                Console.Write("Введите индекс предмета: ");
                if (int.TryParse(Console.ReadLine(), out int index))
                {
                    Item item = inventory.GetItem(index);
                    if (item != null)
                    {
                        ProcessAction(action, item, user, inventory, index);
                    }

                }
                else
                {
                    Console.WriteLine("Неверный индекс");
                }

            }
            else
            {
                Console.WriteLine("Неверное действие");
            }
        }

            static void ProcessAction(int action, Item item, Character character, Inventory inventory, int index)
            {
                switch (action)
                {
                    case 1:
                        if (item is IUsable usable)
                        {
                            usable.Use(character);

                            if (item is IStackable stackable)
                            {
                                stackable.RemoveOne();
                                if (stackable.Count <= 0)
                                {
                                    inventory.RemoveAt(index);
                                }
                            }
                            else
                            {
                                inventory.RemoveAt(index);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Этот предмет нельзя использовать");
                        }
                        break;

                    case 2:
                        if (item is IEquipable equipable)
                        {
                            equipable.Equip(character);
                        }
                        else
                        {
                            Console.WriteLine("Этот предмет нельзя надеть");
                        }
                        break;

                    case 3:
                        if (item is ISellable sellable)
                        {
                            sellable.Sell(character);
                            inventory.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Этот предмет нельзя продать");
                        }
                        break;

                    case 4:
                        if (item is IDiscardable discardable)
                        {
                            discardable.Discard();
                            inventory.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Этот предмет нельзя выбросить");
                        }
                        break;
                }
            }



            static string IntInput()
            {
                while (true)
                {
                    Console.WriteLine("Введите целое число");
                    if (int.TryParse(Console.ReadLine(), out int IntNumber))
                    {
                        return IntNumber.ToString();
                    }
                    else
                    {
                        Console.WriteLine("Введен неверный формат числа");
                    }
                }
            }
        }
    }


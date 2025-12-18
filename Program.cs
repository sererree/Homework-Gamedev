using System;
using kr22;
Door door1 = new Door(1, "дверь закрытая", true);
Door door2 = new Door(2, "дверь открытая", false);
Trap trap1 = new Trap(3, "ловушка", true);
List<GameObject> objects = new List<GameObject> { door1, door2, trap1 };
Scene scene = new Scene(objects);
Player player = new Player(50);
scene.PrintAll();



while (true)
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1 - Показать все объекты");
    Console.WriteLine("2 - Показать только интерактивные объекты");
    Console.WriteLine("3 - Взаимодействовать с объектом по Id");
    Console.WriteLine("4 - Отключить объект по Id");
    Console.WriteLine("5 - Включить объект по Id");
    Console.WriteLine("0 - Выход");

    string input = IntInput();


    if (input == "0")
    {
        break;
    }

    if (int.TryParse(input, out int action) && action >= 1 && action <= 5)
    {
        Console.Write("Введите номер действия: ");
        ProcessAction(action, scene, player, door1, door2, trap1);
    }
    else
    {
        Console.WriteLine("Неверное действие");
    }
}

static void ProcessAction(int action, Scene scene,Player player, Door door1, Door door2, Trap trap1)
{
    switch (action)
    {
        case 1:
            scene.PrintAll();
            break;
        case 2:
            for (int i  = 0; i < scene.Objects.Count;i++)
            {
                if (scene.Objects[i] is IInteractable)
                {
                    Console.WriteLine(scene.Objects[i].Info());
                }
            }
        break;
        case 3:
            Console.WriteLine("Выберите ID");
            string inputAction = IntInput();
            for (int i = 0; i < scene.Objects.Count; i++)
            {
                if (scene.Objects[i].id.ToString() == inputAction)
                {
                    if (scene.Objects[i] is IInteractable interactable)
                    {
                        interactable.Interact(player);
                    }
                    else
                    {
                        Console.WriteLine("Object is not interactable");
                    }
                }
            }
            break;
        case 4:
            Console.WriteLine("Выберите ID");
            string inputDisable = IntInput();
            for (int i = 0; i < scene.Objects.Count; i++)
            {
                if (scene.Objects[i].id.ToString() == inputDisable)
                {
                    scene.Objects[i].Disable();
                }
            }
            break;
        case 5:
            Console.WriteLine("Выберите ID");
            string inputEnable = IntInput();
            for (int i = 0; i < scene.Objects.Count; i++)
            {
                if (scene.Objects[i].id.ToString() == inputEnable)
                {
                    scene.Objects[i].Enable();
                }
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

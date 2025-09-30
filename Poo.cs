
class Poo
{
    public string Name;
    int _hp = 100;
    int _maxHp = 100;
    int _hunger = 100;

    List<Food> _availableFoods = new();

    public Poo()
    {
        System.Console.WriteLine("What is your companion name?");
        while (true)
        {
            Name = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(Name))
            {
                break;
            }
            System.Console.WriteLine("Choice A Valid Name!");

        }
    }

    public void AddToAvailableFood(Food food)
    {
        _availableFoods.Add(food);
    }

    public void Feed(Food food)
    {
        _hunger += food.Hunger;
        if (_hunger > 100)
        {
            _hunger = 100;
        }
    }

    bool IsAlive()
    {
        if (_hp <= 0)
        {
            return false;
        }
        else return true;
    }

    public bool GetAlive()
    {
        return IsAlive();
    }

    void HungerTakeDamage(int hungerDamage)
    {

        if (_hunger <= 0)
        {
            _hp -= hungerDamage;
        }
        else
        {
            _hunger -= hungerDamage;

        }
    }


    public void Tick(List<Food> foods)
    {
        HungerTakeDamage(20);
        System.Console.WriteLine("What do you want to do?\n1). Feed\n2). Play\n3). Pet");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice)) return;

        switch (choice)
        {
            case 1:
                System.Console.WriteLine("You chose to feed.");
                Feed(SelectFood(foods));
                break;
        }
    }

    Food SelectFood(List<Food> foods)
    {
        for (int i = 0; i < foods.Count; i++)
        {
            foods[i].PrintStats();
        }

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            System.Console.WriteLine("Choose a valid food");
        }

        return foods[choice - 1];
    }

    public void PrintStats()
    {
        System.Console.WriteLine($"{Name} HP: {_hp}, Hunger: {_hunger}");
    }

}

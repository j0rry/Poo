using System.Xml.Serialization;

class Poo
{
    public int Hp = 100;
    public int MaxHp = 100;
    public int Hunger = 100;
    string Name = "Pou";


    public Poo(string name)
    {
        Name = name;
    }

    public void Feed(Food food)
    {
        Hunger += food.Hunger;
        if (Hunger > 100)
        {
            Hunger = 100;
        }
    }

    public void HungerTakeDamage()
    {

        if (Hunger <= 0)
        {
            Hp -= 1;
        }
        else
        {
            Hunger -= 1;
        }
    }

    public void Tick(List<Food> foods)
    {
        HungerTakeDamage();
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

    public Food SelectFood(List<Food> foods)
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

        return foods[choice-1];
    }

    public void PrintStats()
    {
        System.Console.WriteLine($"{Name} HP: {Hp}, Hunger: {Hunger}");
    }
    
}
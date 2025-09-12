class Food
{
    string Name;
    public int Hunger;

    public Food(string name, int hunger)
    {
        Name = name;
        Hunger = hunger;
    }

    public void PrintStats()
    {
        System.Console.WriteLine($"{Name}, Feeds: {Hunger}");
    }
}
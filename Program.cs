List<Food> foods = [
    new("Apple", 10),
    new("Banana", 15),
    new("Cookie", 25)
];

Poo pou = new();
foods.ForEach(food => pou.AddToAvailableFood(food));

while (pou.GetAlive())
{
    pou.PrintStats();
    pou.Tick(foods);
}


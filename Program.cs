List<Food> foods = [
    new("Apple", 10),
    new("Banana", 15),
    new("Cookie", 25)
];

Poo pou = new(Console.ReadLine());

while (pou.Hp >= 0)
{
    pou.PrintStats();
    pou.Tick(foods);
}


Console.ReadLine();


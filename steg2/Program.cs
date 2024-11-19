// 1
List<string> toys = ["bil", "tåg", "playmobile", "lego", "transformers"];

// 2
for (int i = 0; i < toys.Count; i++)
{
    Console.WriteLine(toys[i]);
}

// 3
List<string> comrades = ["Nilo", "Alexander1", "Alexander2", "Jack", "Teo"];

// 4
List<int> number123 = [9, 8, 3, 2, 6];

// 5
for (int i = 0; i < toys.Count; i++)
{
    Console.WriteLine($"{comrades[i]} ger {toys[i]} betyget {number123[i]}");
}

// 6
List<string> cities = [];

// 7 och 8
string city = "";

while(city != "hm")
{
    city = Console.ReadLine();
    cities.Add(city);
}
for (int i = 0; i < cities.Count; i++)
{
    Console.WriteLine(cities[i]);
}















Console.ReadLine();
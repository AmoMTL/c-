Random coin = new Random();
int chance = coin.Next(1,3);
Console.WriteLine(chance == 2 ? "Heads" : "Tails");
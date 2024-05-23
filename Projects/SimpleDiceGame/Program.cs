Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

Console.WriteLine("Results:\n");
Console.WriteLine($"Dice 1: \t\t {roll1}\nDice 2: \t\t {roll2}\nDice 3: \t\t {roll3}");

int total = roll1 + roll2 + roll3;
if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    total += 2;
    Console.WriteLine("You rolled doubles! you get 2 bonus points :)");
}
else if ((roll1 == roll2) && (roll2 == roll3))
{
    total += 6;
    Console.WriteLine("You rolled triples! you get 6 bonus points :D");
}

Console.WriteLine($"\n Total score: \t{total}");

if (total >= 15)
{
    Console.WriteLine("Congratulations! you won");
}
else
{
    Console.WriteLine("You lose, better luck next time.");
}

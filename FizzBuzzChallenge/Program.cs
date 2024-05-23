for(int number = 1; number <= 100; number++)
{
    Console.Write(number + "\t");
    if (number % 3 == 0) Console.Write("Fizz");
    if (number % 5 == 0) Console.Write("Buzz");
    Console.WriteLine();
}
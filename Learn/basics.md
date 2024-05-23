# C# , .NET framework

## Create app directory
```bash
dotnet new console -n MyFirstApp

cd MyFirstApp
dotnet run

dotnet build
```

## Basics
``` C#
// Basics
Console.WriteLine("Hello World!"); //appends a new line after, str literal
Console.Write("Hello"); // writes continuously

//Literal values
Console.Write('b'); //char literal
Console.Write(123); //int literal
Console.Write(0.25F); //float literal ~6-9 digits
Console.Write(2.625); //double literal ~15-17 digits
Console.Write(12.3534m); //decimal literal ~28-29 digits

Console.Write(true);
Console.Write(false); //boolean literals

// Declare variables "human friendly name compiler assigns to a memory address"
string FirstName;
char userOption;
int gameScore;
decimal particlesPerMillion;
float number;
double number2;
bool processedCustomer;

//arrays
string[] orders = new string[3]; //array of size 3
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

firstName = "Bob";

// var to implicitly assign variable type
var message = "Hello world"; //str type
var num = 9; //int type

//verbatim string @
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)"); //no neeed to use // or /n

//unicode escape characters
// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// string interpolation
string message = $"{greeting} {firstName}!";

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

//mathematical operations
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

//type casting
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
```

## .NET Class library

The .NET Class Library is a collection of thousands of classes containing tens of thousands of methods. For example, the .NET Class Library includes the Console class for developers working on console applications. The Console class includes methods for input and output operations such as `Write()`, `WriteLine()`, `Read()`, `ReadLine()`, and many others.

First of all, remember that finding every class and method in the .NET Class Library is like finding every book in a large public library. You don't need every book in the library, and you won't be using every class and method in the .NET Class Library. Depending on the types of projects that you work on, you'll become more familiar with some parts of the .NET Class Library and less familiar with others. Again, it's like spending time in a section of the public library, over time you become familiar with what's available. No one knows all of the .NET Class Library, not even people that work at Microsoft.

Second, necessity will drive you to what you need. Most people go to the library when they need to find a book, not to see how many different books they can find. You don't need to research classes and methods without a reason. When you have trouble figuring out a programming task, you can use your favorite search engine to find blog posts, articles, or forums where other developers have worked through similar issues. Third-party sources can give you clues about which .NET classes and methods you might want to use, and you may even find sample code that you can try.

Third, Microsoft provides an online language reference and programming guide for C# that you can search through. You'll likely spend time reading Microsoft's documentation when you need to understand exactly what methods do, how they work, and their limitations. This documentation will become your source of truth for the .NET Class Library. Microsoft's documentation team works closely with the .NET Class Library's software developers to ensure its accuracy.

```c#
// random method
Random dice = new Random() // create new instance of random class
Random dice = new(); //latest way to do it
int roll = dice.Next(1,7);
```
### stateful vs stateless methods

In software development projects, the term state is used to describe the condition of the execution environment at a specific moment in time. As your code executes line by line, values are stored in variables. At any moment during execution, the current state of the application is the collection of all values stored in memory.

Some methods don't rely on the current state of the application to work properly. In other words, stateless methods are implemented so that they can work without referencing or changing any values already stored in memory. **Stateless methods** are also known as **static methods**.

For example, the `Console.WriteLine()` method doesn't rely on any values stored in memory. It performs its function and finishes without impacting the state of the application in any way.

Other methods, however, must have access to the state of the application to work properly. In other words, **stateful methods** are built in such a way that they rely on values stored in memory by previous lines of code that have already been executed. Or they modify the state of the application by updating values or storing new values in memory. They're also known as **instance methods**.

## Decision logic (if, else, elseif)

```c#
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
```

## Arrays and iterating with foreach

```c#
string[] fraudulentOrderIDs = new string[3]; // array of size 3
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

int arrayLength = fraudulentOrderIDs.Length

//foreach
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

//example usage
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");
```

## Conditional operator

```c#
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

//example
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
```

## switch case 

```c#
switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
    default:
        Console.WriteLine("Unavaiable")
}
```

## for loop

```c#
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
```

## do - while loop

```c#
do
{
    // This code executes at least one time
} while (true);

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
```

```c#
//example usage
Random random = new Random();
int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
```

## user input

When using a `Console.ReadLine()` statement to obtain user input, it's common practice to use a nullable type string (designated `string?`) for the input variable and then evaluate the value entered by the user. The following code sample uses a nullable type string to capture user input. The iteration continues while the user-supplied value is null:
```c#
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);
```

```c#
//example
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
```

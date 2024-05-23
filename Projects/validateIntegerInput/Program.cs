bool flag = true;
string? readResult;
int number = 0;

Console.WriteLine("Enter a number between 5 and 10");
do
{
    readResult = Console.ReadLine();
    int.TryParse(readResult, out number);
    if (number <=10 && number > 5) flag=false;
    else Console.WriteLine("Invalid input - enter a number between 5 and 10");
}while (flag);

Console.WriteLine($"User input of {readResult} accepted.");
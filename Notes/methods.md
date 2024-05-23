## Popular methods
* `int.TryParse()`
```c#
int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);
```
* `mystring.IndexOf()`
```c#
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
foreach string myString in myStrings
{
    locationIndex = myString.IndexOf(".");
    Console.WriteLine(locationIndex)
}
```

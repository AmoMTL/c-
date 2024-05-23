using System;

class Program
{
    static void Main()
    {
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

        foreach (string myString in myStrings)
        {
            bool flag2 = true;
            int indexInitial = 0;
            int indexEnd;
            int counter = 0;
            string newMyString = myString;

            do
            {
                indexEnd = newMyString.IndexOf(".", indexInitial);
                if (indexEnd != -1)
                {
                    Console.WriteLine(newMyString.Substring(indexInitial, indexEnd - indexInitial).Trim());
                    indexInitial = indexEnd + 1; // Update the start index for the next substring search
                    counter++;
                }
                else
                {
                    flag2 = false;
                }
            } while (flag2);
            if (counter == 0) Console.WriteLine(newMyString);
        }
    }
}

Console.WriteLine("Enter a string:");
string input = Console.ReadLine();

string lastFiveCharachters = input.Substring(input.Length - 5);
Console.WriteLine($"The last 5 charachters of {input} are: {lastFiveCharachters}");


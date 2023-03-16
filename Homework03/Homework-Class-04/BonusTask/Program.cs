Console.WriteLine("Enter a sentence: ");
string sentence = Console.ReadLine();

string[] words = sentence.Split(" ");
string largestWord = "";

foreach (string word in words)
{
    if (word.Length > largestWord.Length)
    {
        largestWord = word;
    }
}

Console.WriteLine($"The largest word in the sentence is \"{largestWord}\".");
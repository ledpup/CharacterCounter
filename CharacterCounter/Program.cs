//var words = File.ReadAllLines("3000_words.txt");
var words = File.ReadAllLines("corncob_lowercase.txt");


var letterCount = new int[26];

foreach (var word in words)
{
    var lowerCaseWord = word.ToLower().Replace("-", string.Empty);

    foreach (var letter in lowerCaseWord)
    {
        letterCount[((short)letter) - 97]++;
    }
}
var total = 0;
for (var i = 0; i < 26; i++)
{
    total += letterCount[i];
    
    Console.WriteLine($"{(char)(i + 97)} = {letterCount[i]}");
}
var average = total / (double)words.Length;

Console.WriteLine();
Console.WriteLine($"Total number of characters = {total}. Average number of letters in a word {average}. Most popular letter is '{(char)(Array.IndexOf(letterCount, letterCount.Max()) + 97)}'.");
Console.WriteLine();

letterCount.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine($"{(char)(Array.IndexOf(letterCount, x) + 97)} = {x}"));
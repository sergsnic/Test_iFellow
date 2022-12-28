// Задача 2 средняя:
// Написать программу, которая должна найти и вывести повторяющийся символ в слове «Hello»

string word = "Hello";
for (int i = 0; i < word.Length; i++)
{
    for (int j = i + 1; j < word.Length; j++)
        if (word[j] == word[i]) Console.WriteLine($"Повторяющийся символ в слове {word} - {word[i]}");
}

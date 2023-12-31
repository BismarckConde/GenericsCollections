﻿HashSet<int> evenNumbers = new HashSet<int>();
HashSet<int> oddNumbers = new HashSet<int>();

for (int i = 0; i < 5; i++)
{
    evenNumbers.Add(i * 2);
    oddNumbers.Add((i * 2) + 1);
}

Display("even numbers", evenNumbers);
Display("odd numbers", oddNumbers);

HashSet<int> numbers = new HashSet<int>(evenNumbers);
numbers.UnionWith(oddNumbers);
Display("numbers", numbers);

numbers.Add(1);
Display("numbers", numbers);

void Display(string title, HashSet<int> numbers)
{
    Console.WriteLine(title);
    foreach (var item in numbers)
    {
        Console.Write($"{item}, ");
    }
    Console.WriteLine();
}

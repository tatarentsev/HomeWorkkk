string[] strings = {"hello", "2", "world", ":)"}; // 4

int count = 0; // 2
for (int j = 0; j < strings.Length; j++) // 0 < 3
{
    if (strings[j].Length <= strings.Length + 1)
    {
        count++; // 2
    }
}


string[] copy = new string[count];
for (int i = 0; i < copy.Length; i++) // 0 < 2
{
    if (strings[i].Length <= 3)
    {
        copy[i] = strings[i];
    }
}

Console.Write("[");
for (int k = 0; k < count; k++)
{
    Console.Write($"{copy[k]} ");
}
Console.Write("]");
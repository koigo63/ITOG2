string[] strings = { "qqq", "ww", "eeee", "rr", "t", "yyyyy" };
string[] CreateRandomArray(string[] strings)
{
    string[] myArray = new string[strings.Length];
    int j = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length < 4)
        {
            myArray[j] = strings[i];
            j = j + 1;
        }
        else
        { }
    }
    return myArray;
}

void ShowArray(string[] array)
{
    Console.WriteLine("Полученный массив->");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ShowArray1(string[] array)
{
    Console.WriteLine("Исходный массив->");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
ShowArray1(strings);
string[] newarray = CreateRandomArray(strings);
ShowArray(newarray);
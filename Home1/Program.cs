string[] strings = { "qq", "ww", "ee", "rr", "tt", "yy" };
string[] CreateRandomArray(string[] strings)
{
    int numb = new Random().Next(0, 4);
    string[] myArray = new string[numb];
    Console.WriteLine($" N= {numb} ");
    for (int i = 0; i < numb; i++)
    {
        int j = new Random().Next(0, strings.Length - 1);
        myArray[i] = strings[j];
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
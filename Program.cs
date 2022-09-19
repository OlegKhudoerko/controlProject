int maxLenght = 3;
string[] array = InputArray()!.Split();
string[] secondArray = new string[CountMaxLength()];
CollectArray();
int CountMaxLength()
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLenght)
        {
            j++;
        }
    }
    return j;
}

string InputArray()
{
    Console.Write("\nВведите через ПРОБЕЛ несколько слов,символов или чисел  => ");
    string? getArray = Console.ReadLine();
    return getArray!;
}
int CollectArray()
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLenght)
        {
            secondArray[j] = array[i];
            j++;
        }
    }
    return j;
}
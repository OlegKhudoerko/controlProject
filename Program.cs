
string[] array = InputArray()!.Split();
string InputArray()
{
    Console.Write("\nВведите через ПРОБЕЛ несколько слов,символов или чисел  => ");
    string? getArray = Console.ReadLine();
    return getArray!;
}
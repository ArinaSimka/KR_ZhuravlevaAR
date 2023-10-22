
int GetNumber(string message)
{
    Console.Write($"Введите значение {message}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

string GetSt(string message)
{
    Console.Write($"Введите значение {message}:");
    string n = Console.ReadLine();
    return n;
}

string[] GetArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = GetSt("элемента массива");
    }
    return array;
}

void Print(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    { Console.Write($"   {arr[i]} "); }
    Console.WriteLine();
}

string[] Select(string[] arr)
{
    int j = 0;
    string[] arrayNew = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {

        string num = arr[i];
        char[] array = num.ToCharArray();
        if (array.Length < 4)
        {
            arrayNew[j] = arr[i];
            j = j + 1;
        }
    }
    return arrayNew;
}

int size = GetNumber("размерности массива");
string[] array = GetArray(size);
Print(array);
Console.WriteLine("Значения, длина которых меньше, либо равна 3 символам:");
string[] array2 = Select(array);
Print(array2);


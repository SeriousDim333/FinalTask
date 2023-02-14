
string[] GetArray()
{
    string elementOfArray = string.Empty;
    int count = 0;
    string[] newArray = new string[count];
    string[] temp = new string[count];
    while (elementOfArray != "stop")
    {
        Console.WriteLine("введите элемент массива или 'stop' для завершения");
        elementOfArray = Console.ReadLine();
        if (elementOfArray != "stop")
        {
            count++;
            newArray = new string[count];
            for (int i = 0; i < temp.Length; i++)
            {
                newArray[i] = temp[i];
            }
            newArray[count - 1] = elementOfArray;
            temp = newArray;
        }
    }
    return newArray;
}

string[] ResultArray(string[] array)
{
    int count = 0;
    string[] result = new string[count];
    string[] temp = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            count++;
            result = new string[count];
            for (int k = 0; k < temp.Length; k++)
            {
                result[k] = temp[k];
            }
            result[count - 1] = array[i];
            temp = result;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    if (array.Length > 0)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"'{array[i]}' ");
        }
        Console.Write($"'{array[array.Length - 1]}'");
        Console.Write("]");
    }
    else
    {
        Console.WriteLine("[]");
    }
}

string[] array = GetArray();
Console.WriteLine($"введенный массив:");
PrintArray(array);
Console.WriteLine();
string[] resultArray = ResultArray(array);
Console.WriteLine($"массив с элементами длинной меньше или равной 3:");
PrintArray(resultArray);
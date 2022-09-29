System.Console.WriteLine("Введите значения массива через Enter, чтобы закончить ввод введите слово stop: ");

string strArr = String.Empty;
strArr += ArrayInput();
string[] array = FillArray(strArr, ElementCount(strArr));

System.Console.WriteLine($"Введенный массив -> [{string.Join(", ", array)}]");
System.Console.WriteLine($"Итоговый массивв -> [{string.Join(", ", SecondArrayWithElementsOfThreeChar(array))}]");

Console.ReadKey();

string[] SecondArrayWithElementsOfThreeChar(string[] initialArr)
{
    string[] resultArr = new string[initialArr.Length];
    int count = 0;

    for (int i = 0; i < initialArr.Length; i++)
    {
        if (initialArr[i].Length <= 3)
        {
            resultArr[count] = initialArr[i];
            count++;
        }
    }
    Array.Resize(ref resultArr, count);
    return resultArr;
}

string ArrayInput()
{
    string s = System.Console.ReadLine();
    if (s.ToLower() == "stop")
    {
        return "";
    }
    else
    {
        return s + " " + ArrayInput();
    }
}

int ElementCount(string s)
{
    int count = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == ' ')
        {
            count++;
        }
    }
    return count;
}

string[] FillArray(string str, int count)
{
    string[] array = new string[count];
    int j = 0;
    for (int i = 0; i < count; i++)
    {
        string s = "";

        while (str[j] != ' ' && j < str.Length)
        {
            s += str[j];
            j++;
        }

        j++;
        array[i] = s;
    }
    return array;
}
System.Console.WriteLine("Введите значения массива через Enter, чтобы закончить ввод введите слово stop: ");
string strArr = String.Empty;

strArr += ArrayInput();
int m = ElementCount(strArr);
string[] array = FillArray(strArr, m);
System.Console.WriteLine($"Введенный массив -> [{string.Join(", ", array)}]");

System.Console.WriteLine($"Введенный массив -> [{string.Join(", ", SecondArrayWithElementsOfThreeChar(array))}]");

string [] SecondArrayWithElementsOfThreeChar (string[] initialArr)
{
    string[] resultArr = new string [initialArr.Length];
    int count = 0;

    for (int i=0; i< initialArr.Length; i++)
    {
        if(initialArr[i].Length <=3)
        {
            resultArr[count] = initialArr[i];
            count++;
        }
    }
    return resultArr;
}

string ArrayInput()
{
    string s = Console.ReadLine();
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
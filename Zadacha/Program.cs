/*Написать программу, которая из имеющегося массива строк формирует
 массив строк, длина которых меньше либо равна 3 символа. 
 Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма. */

Console.Clear();

int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

string[] GetArray(int N)
{
    string[] array = new string[N];
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Введите массив:");
    Console.ResetColor();
    for (int i = 0; i < N; i++)
    {
        Console.Write($"array[{i}] = ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("Полученный массив : [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int GetLengthNewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string str = array[i];
        if (str.Length <= 3)
        {
            count = count + 1;
        }
    }
    return count;
}

string[] GetNewArray(string[] array, int count)
{
    string[] newArray = new string[count];
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string str = array[i];
        if (str.Length <= 3)
        {
            newArray[temp] = array[i];
            temp = temp + 1;
        }
    }
    return newArray;
}

int N = GetDataFromUser("Введите количество элементов массива:");
string[] array = GetArray(N);
int count = GetLengthNewArray(array);
string[] newArray = GetNewArray(array, count);
PrintArray(newArray);


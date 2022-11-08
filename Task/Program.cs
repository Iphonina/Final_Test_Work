// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
//либо равна 3 символа.

int GetSizeFirstArray()
{
    Console.Write("Введите длину массива: ");
    int sizeArr = Convert.ToInt32(Console.ReadLine());
    while(sizeArr < 1)
    {
        Console.Write("Введено некорректное значение, повторите ввод    : ");
        sizeArr = Convert.ToInt32(Console.ReadLine());
    }
    return sizeArr;
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        array[i] = Console.ReadLine();
    }
}

int GetSizeNewArray(string[] array, int num)
{
    int count = 0;
    foreach (string v in array)
    {
        if (v.Length <= num)
        {
            count++;
        }
    }
    return count;
}

void GetAndPrintNewArray(string[] array1, string[] array2, int num)
{
    int index = 0;
    Console.Write($"[");
    foreach (string v in array1)
    {
        if (v.Length <= num)
        {
            array2[index] = v;
            Console.Write($"{array2[index]}, ");
            index++;
        }
    }
    Console.Write("\b" + "\b");
    Console.Write($"]");
}


int sizeArray = GetSizeFirstArray();
int maxWordLength = 3;

string[] firstArray = new string[sizeArray];
FillArray(firstArray);

string[] newArray = new string[GetSizeNewArray(firstArray, maxWordLength)];
GetAndPrintNewArray(firstArray, newArray, maxWordLength);
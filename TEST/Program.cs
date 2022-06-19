// Контрольная работа на языке С#.
// Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам

void PrintArray(string[] array)
{
    int length = array.Length;
    if (length > 0)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }
}
string[] ExtractWordBeforeNChar(string[] array, int N)
{
    int length = array.Length;
    string[] resultArray = new string[length];
    int j = 0;
    for (int i = 0; i < length; i++)
    {
        if ((array[i].Length) > 0 && (array[i].Length <= N))
        {
            resultArray[j] = array[i];
            j = j + 1;
        }
    }
    Array.Resize(ref resultArray, j);
    return resultArray;
}

Console.WriteLine("Исходный массив значений:");
string[] arrayInput = {"Hello","2","world",":-)","1234","1567","-2",
                       "computer","science","Russia","Denmark","Kazan"};
PrintArray(arrayInput);
Console.WriteLine();
Console.Write("Выборка строк, длина которых меньше, либо равна (введите число): ");
int value = int.Parse(Console.ReadLine());
if (value > 0)
{
    string[] arrayCreate = ExtractWordBeforeNChar(arrayInput, value);
    PrintArray(arrayCreate);
}
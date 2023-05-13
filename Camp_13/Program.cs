//сортировка подсчетом

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}

void CompetitionArray(int[] array, int[] HelpArray)
{
    for (int i = 0; i < array.Length; i++)
        HelpArray[array[i]] += 1;
}

void SortArray(int[] array, int[] HelpArray)
{
    int j = 0;
    for (int i = 0; i <= 100; i++)
    {
        while (HelpArray[i] > 0)
        {
            array[j] = i;
            j++;
            HelpArray[i]--;
        }
    }
}


Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
int[] HelpArray = new int[101];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
CompetitionArray(array, HelpArray);
SortArray(array, HelpArray);
Console.WriteLine($"\nОтсортированный массив: \n[{string.Join(", ", array)}]");
/*Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз 
встречается элемент входных данных. Значения элементов массива 0..9
*/
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int[] Frequency(int[,] array)
{
    int[] number = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            number[array[i, j]]++;
        }
    }
    return number;
}
Console.Clear();
int[,] massive = new int[4, 4];
FillArray(massive);
PrintArray(massive);
System.Console.WriteLine();
int[] freq = Frequency(massive);
for (int i = 0; i < freq.Length; i++)
{
    System.Console.WriteLine($"количество элементов {i} составляет {freq[i]} ");
}
/*Задача 2: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
int[,] CreateMatrix(int x, int y)
{
    int[,] matrix = new int[x, y];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}
int stringSummElement(int[,] array)
{
    int[] summString = new int[array.GetLength(0)];
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summString[i] = summString[i] + array[i, j];
        }
    }
    int min = summString[0];
    for (int i = 0; i < summString.Length; i++)
    {
        if (summString[i] < min)
        {
            min = summString[i];
            result = i;
        }
    }
    return result + 1;
}
Console.Clear();
int x = InputInt("Введите количество строк и столбцов прямоугольного массива > ");
int[,] matrix = CreateMatrix(x, x);
PrintArray(matrix);
System.Console.WriteLine();
x = stringSummElement(matrix);
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов  {x}");
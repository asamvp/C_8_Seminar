/*Задача 1: Задайте двумерный массив. Напишите программу,
 которая упорядочивает по убыванию элементы каждой строки двумерного массива.*/
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
int[,] stringOrdering(int[,] array)
{
    int buffer = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    buffer = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = buffer;
                }
            }
        }
    }
    return array;
}
Console.Clear();
int x = InputInt("Введите количество строк массива > ");
int y = InputInt("Введите количество столбцов массива > ");
int[,] matrix = CreateMatrix(x, y);
PrintArray(matrix);
System.Console.WriteLine();
matrix = stringOrdering(matrix);
PrintArray(matrix);
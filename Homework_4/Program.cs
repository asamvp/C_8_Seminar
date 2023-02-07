/*Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.*/
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
int[,] Spiral(int x)
{
    int[,] matrix = new int[x, x];
    int i = 0, j = 0, k = 0;
    int value = 1;
    for (int e = 0; e < matrix.GetLength(0) / 2; e++)
    {
        for (k = 0; k < x - 1; k++) { matrix[i, j++] = value++; }
        for (k = 0; k < x - 1; k++) { matrix[i++, j] = value++; }
        for (k = 0; k < x - 1; k++) { matrix[i, j--] = value++; }
        for (k = 0; k < x - 1; k++) { matrix[i--, j] = value++; }
        i++;
        j++;
        x -= 2;
    }
    if (matrix.GetLength(0) % 2 != 0) { matrix[i, j++] = value++; } //если массив нечетный нужно заполнить в середине последниее значение
    return matrix;
}
Console.Clear();
int x = InputInt("Введите количество строк и столбцов прямоугольного массива > ");
int[,] matrix = Spiral(x);
PrintArray(matrix);
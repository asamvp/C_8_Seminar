/*Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/
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
bool checkMatrix(int[,] arrayA, int[,] arrayB)
{
    if (arrayA.GetLength(1) == arrayB.GetLength(0))
    {
        return true;
    }
    return false;
}
int[,] compositionMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayB.GetLength(0); k++)
            {
                arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }
    return arrayC;
}
Console.Clear();
int x = InputInt("Введите количество строк первой матрицы > ");
int y = InputInt("Введите количество столбцов первой матрицы > ");
int[,] matrixA = CreateMatrix(x, y);
x = InputInt("Введите количество строк второй матрицы > ");
y = InputInt("Введите количество столбцов второй матрицы > ");
int[,] matrixB = CreateMatrix(x, y);
PrintArray(matrixA);
System.Console.WriteLine();
PrintArray(matrixB);
if (checkMatrix(matrixA, matrixB))
{
    int[,] matrixC = compositionMatrix(matrixA, matrixB);
    System.Console.WriteLine("Произведение матриц:");
    PrintArray(matrixC);
}
else
{
    System.Console.WriteLine("Произведение матриц невозможно");
}

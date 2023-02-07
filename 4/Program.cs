/*Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен
 наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7*/
int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{
    //System.Console.WriteLine($"[");
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    // System.Console.WriteLine($"]");
}
(int index_i, int index_j) SearchMin(int[,] arr)
{
    int min_i = 0, min_j = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < arr[min_i, min_j])
            {
                min_i = i; min_j = j;
            }
        }
    }
    return (min_i, min_j);
}
int PromptInt(string mess)
{
    System.Console.Write($"{mess} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int[,] ModifyArray(int[,] arr, int index_i, int index_j)
{
    int[,] result = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int i_result = i;
            int j_result = j;

            if (i_result != index_i && j_result != index_j)
            {
                if (i_result > index_i) i_result--;
                if (j_result > index_j) j_result--;

                result[i_result, j_result] = arr[i, j];
            }
        }
    }
    return result;
}

int m = PromptInt("Введите количество строк массива: ");
int n = PromptInt("Введите количество столбцов массива: ");
int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
(int i_min, int j_min) = SearchMin(matrix);
System.Console.WriteLine($"i_min = {i_min}, j_min = {j_min}");
int[,] res = ModifyArray(matrix, i_min, j_min);
PrintMatrix(res);
/*Задача 1: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.*/

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
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
void Change(int[,] array)
{
    var temp = 0;
    int lastNum = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[lastNum, i];
        array[lastNum, i] = temp;
    }
}

int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
Change(matrix);
System.Console.WriteLine();
PrintArray(matrix);
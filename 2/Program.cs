/*Задача 2: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение 
для пользователя.
*/
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            temp=array[i,j];
            array[i,j]=array[j,i];
            array[j,i]=temp;
        }
    }
}
Console.Clear();
int[,] massive= new int[4,4];
FillArray(massive);
PrintArray(massive);
Change(massive);
System.Console.WriteLine();
PrintArray(massive);
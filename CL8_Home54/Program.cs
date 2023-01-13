/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(String.Format("{0,2:0.#}", arr[i, j]));
        Console.WriteLine();
    }
}

int[,] arr =
{
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 }
};
Console.WriteLine("Массив:");
PrintArray(arr);

for (int i = 0; i < arr.GetLength(0); i++)
{
    int[] row = Enumerable.Range(0, arr.GetUpperBound(1)+1).Select(x => arr[i, x]).ToArray();
    Array.Sort(row);
    Array.Reverse(row);
    for (int j = 0; j < row.Length; j++)
        arr[i, j] = row[j];
}

Console.WriteLine("Упорядоченный массив:");
PrintArray(arr);
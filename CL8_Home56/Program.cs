/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
    { 8, 4, 2, 4 },
    { 5, 2, 6, 7 }
};

var summList = new List<int>();

for (int i = 0; i < arr.GetLength(0); i++)
{
    var sum = Enumerable.Range(0, arr.GetUpperBound(1) + 1).Sum(x => arr[i, x]);
    summList.Add(sum);
}

var x = summList.Select((item, index) => (item, index)).Min().index + 1;

Console.WriteLine("Массив:");
PrintArray(arr);
Console.WriteLine($"Номер строки с минимальной суммой: {x}");
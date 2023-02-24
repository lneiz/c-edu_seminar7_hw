// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateRandom2dArray()
// {
//     Console.Write("Сколько будет строк? m: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Сколько будет столбцов? n: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Минимальное значение массива? ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Маскимальное значение массива? ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());

//     double[,] array = new double[m,n];

//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue + 1) / 10.0;
//         }
//     }

//     return array;
// }

// void ShowArray(double[,] array)
// {
//     Console.WriteLine();
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// ShowArray(CreateRandom2dArray());

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray()
{
    int m = new Random().Next(2, 50);
    int n = new Random().Next(1, 50);

    int[,] array = new int[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(-100, 100);
        }
    }

    return array;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] +" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.Write("Сформирован массив " + array.GetLength(0) + " x " + array.GetLength(1));
    Console.WriteLine();
}

void GetValue(int[,] array)
{
    Console.Write("Введите номер строки: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int col = Convert.ToInt32(Console.ReadLine());

    if(row <= array.GetLength(0))
    {
        if(col <= array.GetLength(1))
        {
            Console.Write("Значение запрашиваемого элемента массива: " + array[row - 1,col - 1]);
        }
        else Console.Write("Элемента с таким индексом не существует в этом массиве - 1");
    }
    else Console.Write("Элемента с таким индексом не существует в этом массиве - 2");
}

int[,] array = CreateRandom2dArray();

ShowArray(array);
GetValue(array);

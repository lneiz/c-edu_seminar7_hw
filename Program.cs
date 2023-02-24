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

// int[,] CreateRandom2dArray()
// {
//     int m = new Random().Next(2, 50);
//     int n = new Random().Next(1, 50);

//     int[,] array = new int[m,n];

//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             array[i,j] = new Random().Next(-100, 100);
//         }
//     }

//     return array;
// }

// void ShowArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] +" ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

//     Console.Write("Сформирован массив " + array.GetLength(0) + " x " + array.GetLength(1));
//     Console.WriteLine();
// }

// void GetValue(int[,] array)
// {
//     Console.Write("Введите номер строки: ");
//     int row = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите номер столбца: ");
//     int col = Convert.ToInt32(Console.ReadLine());

//     if(row <= array.GetLength(0))
//     {
//         if(col <= array.GetLength(1))
//         {
//             Console.Write(row + " " + col + " -> " + array[row - 1,col - 1]);
//         }
//         else Console.Write(row + " " + col + " -> " + "Элемента с таким индексом не существует в этом массиве");
//     }
//     else Console.Write(row + " " + col + " -> " + "Элемента с таким индексом не существует в этом массиве");
// }

// int[,] array = CreateRandom2dArray();

// ShowArray(array);
// GetValue(array);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray()
{
    Console.Write("Количество строк массива? ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Количество столбцов массива? ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Минимаьное значение массива? ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальное значение массива? ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,cols];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
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
            Console.Write(array[i,j] + " ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

void AverageCalc(int[,] array)
{
    double[] resultArray = new double[array.GetLength(1)];

    for(int i = 0; i < array.GetLength(1); i++)
    {
        int count = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            count += array[j,i];
        }
        resultArray[i] = Math.Round(Convert.ToDouble(count) / array.GetLength(0),2);
    }

    Console.WriteLine("Среднее арифметическое каждого столбца: " + String.Join(" ; ", resultArray));
    Console.WriteLine();
}

int[,] array = CreateRandom2dArray();

ShowArray(array);
AverageCalc(array);
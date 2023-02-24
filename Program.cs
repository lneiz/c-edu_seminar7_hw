// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dArray()
{
    Console.Write("Сколько будет строк? m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Сколько будет столбцов? n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Минимальное значение массива? ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Маскимальное значение массива? ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m,n];

    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1) / 10.0;
        }
    }

    return array;
}

void ShowArray(double[,] array)
{
    Console.WriteLine();
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

ShowArray(CreateRandom2dArray());
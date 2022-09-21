// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void GetArray (int m, int n)
{
    double [,] array = new double [m, n]; 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i, j] = Math.Round(((new Random().NextDouble()-0.5)*10),2);
            Console.Write($"{array [i, j]}  ");
        }
        Console.WriteLine();
    }

}
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

GetArray(m, n);

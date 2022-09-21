// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int  GetArray (int rows, int colums)
{
    int [,] array = new int [10, 10]; 
    int number = 0;
    for (int i = 0; i < 10; i++)
    {        
        for (int j = 0; j < 10; j++)
        {
            array [i, j] = Convert.ToInt32 (new Random().Next(0,10));
            Console.Write($"{array [i, j]}  ");
            if (rows == i & colums == j)
            {
                number = array[i-1,j-1];
            }
        }
            Console.WriteLine();
    }
    return number;
}
Console.Write("Введите позицию элемента в строке (1-10): ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите позицию элемента в столбце (1-10): ");
int colums = Convert.ToInt32(Console.ReadLine());

if (rows <=10  & colums <= 10)
{
   int number = GetArray(rows, colums);
   Console.WriteLine($"В позиции {rows}, {colums} находится число {number}");
}
else
{
    Console.WriteLine($"{rows} {colums} такой позиции нет в массиве!");
   
}


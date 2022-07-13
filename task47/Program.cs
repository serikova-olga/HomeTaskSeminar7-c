/*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int Input(string output) 
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = Input("Input m: ");
int n = Input("Input n: ");

double[,] numbers = new double[m, n];
Random rnd = new Random();

    for (int i = 0; i < numbers.GetLength(0); i++)//заполнение двухмерного массива рандом
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           numbers [i, j] = rnd.NextDouble()*10;
        }
    }
PrintArray(numbers);
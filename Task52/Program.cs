void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Average (int[,] matr)
{
    double[] total = new double [matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            total [j] += matr[i,j];
        }
        Console.Write(Math.Round((total[j] / matr.GetLength(0)), 2) + "||");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк и столбцов матрицы");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

while ((rows <= 0) || (columns <= 0))
{
    Console.WriteLine("Введите числа больше нуля");
    rows = Convert.ToInt32(Console.ReadLine());
    columns = Convert.ToInt32(Console.ReadLine());
}

int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine("Среднее арифметическое каждого столбца:");
Average(matrix);
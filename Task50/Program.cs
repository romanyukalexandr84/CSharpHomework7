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

int SearchForElement (int[,] matr, int indexRow, int indexColumn)
{
    return matr [indexRow,indexColumn];
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

Console.WriteLine("Введите позиции искомого элемента (отсчет с нуля)");
int rowPos = Convert.ToInt32(Console.ReadLine());
int columnPos = Convert.ToInt32(Console.ReadLine());

if ((rowPos >= 0) && (rowPos < rows) && (columnPos >=0) && (columnPos < columns))
{
    Console.WriteLine("Искомый элемент = "+SearchForElement(matrix, rowPos, columnPos));
}
else
{
    Console.WriteLine("Такого числа в массиве нет");
}
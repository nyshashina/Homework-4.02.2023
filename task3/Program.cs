// В прямоугольной матрице найти строку с наименьшей суммой элементов.
void PrintMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[i,j]} ");
        }
        Console.WriteLine();
    }

}
void FillMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j =0; j < arg.GetLength(1); j++)
        {
            arg[i,j] = new Random().Next(0,10);
        }
    }
}
void SumString(int[,] arg)
{
    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0; i < arg.GetLength(1); i++)
    {
        sum1 = sum1 + arg[0,i];
    }
    Console.WriteLine($"Сумма элементов 0 строки равна {sum1}");
    for (int j = 1; j < arg.GetLength(0); j++)
    {
        for (int k = 0; k < arg.GetLength(1); k++)
        {
            sum2 = sum2 + arg[j,k];
        }
        Console.WriteLine($"Сумма элементов {j} строки равна {sum2}");
        if (sum2 < sum1)
        {
            sum1 = sum2;
            count = j;
        }
        sum2 = 0;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов {count}");
}
Console.WriteLine("Введите количество строк");
int numberM = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите количество столбцов");
int numberN = int.Parse(Console.ReadLine() ?? "0");

int[,]matrix = new int[numberM, numberN];

FillMatrix(matrix);
PrintMatrix(matrix);
SumString(matrix);
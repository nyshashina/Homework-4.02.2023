// Написать программу упорядочивания по убыванию элементы каждой строки двумерной массива.
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
void SortMatrix(int[,] arg)
{
    int temp = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            for (int k = j + 1; k < arg.GetLength(1); k++)
            {
                if (arg[i,j] < arg [i,k])
                {
                    temp = arg[i,j];
                    arg[i,j] = arg[i,k];
                    arg[i,k] = temp;
                }
            }
        }
    }
}
Console.WriteLine("Введите количество строк");
int numberM = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите количество столбцов");
int numberN = int.Parse(Console.ReadLine() ?? "0");

int[,]matrix = new int[numberM, numberN];

FillMatrix(matrix);
PrintMatrix(matrix);
SortMatrix(matrix);
Console.WriteLine("");
PrintMatrix(matrix);

// Написать программу, которая обменивает элементы первой строки и последней строки
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
void SwapStrings(int[,] arg)
{
    int temp = 0;
    int temp1 = arg.GetLength(0) - 1;
    for (int j = 0; j < arg.GetLength(1); j++)
    {
        temp = arg[0,j];
        arg[0,j] = arg[temp1,j];
        arg[temp1,j] = temp;
    }
}
Console.WriteLine("Введите количество строк");
int numberM = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите количество столбцов");
int numberN = int.Parse(Console.ReadLine() ?? "0");

int[,]matrix = new int[numberM, numberN];

FillMatrix(matrix);
PrintMatrix(matrix);
SwapStrings(matrix);
Console.WriteLine("");
PrintMatrix(matrix);
int[,] CreateMatrixRnd (int rowCount, int columsCount, int min, int max)
{
int[,] matrix = new int[rowCount,columsCount];
Random rnd = new Random();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       matrix[i,j] = rnd.Next(min,max);
    }
}
return matrix;
}
void ShowMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}
}

int[,] matrix = CreateMatrixRnd(5, 5, 1, 100);
ShowMatrix(matrix);

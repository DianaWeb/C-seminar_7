/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4 */
System.Console.WriteLine("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, 0, 9);
PrintMatrix(ourMatrix);
System.Console.WriteLine();
SqrEvenIndexes(ourMatrix);
PrintMatrix(ourMatrix);

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
	int[,] matrix = new int[rowsCount, columnsCount];

	Random random = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = random.Next(leftRange, rightRange + 1);
		}
	}
	return matrix;
}
void SqrEvenIndexes(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i += 2)
	{
		for (int j = 0; j < matrix.GetLength(1); j += 2)
		{
			matrix[i, j] = matrix[i, j] * matrix[i, j];
		}
	}
}
void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			System.Console.Write(matrix[i, j] + " ");
		}
		System.Console.WriteLine();
	}
}
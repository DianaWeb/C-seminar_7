/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12

Доп.условие для 51 задачи: сделать суммирование в один цикл.Матрица может быть прямоугольный */
System.Console.WriteLine("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] ourMatrix = GetMatrix(m, n, 0, 9);
PrintMatrix(ourMatrix);
int summ = GetSumMainDiagonal(ourMatrix);
System.Console.WriteLine(summ);

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
int GetSumMainDiagonal(int[,] matrix)
{
	int sum = 0;
	/* for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (i == j)
			{
				sum = sum + matrix[i, j];
			}
		}
	} */
	int min; // способ второй с использованием одного цикла 
	if (matrix.GetLength(0) > matrix.GetLength(1))
	{
		min = matrix.GetLength(1);
	}
	else min = matrix.GetLength(0);
	for (int i = 0; i < min; i++)
	{
		sum = sum + matrix[i, i];
	}
	return sum;
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
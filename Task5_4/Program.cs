int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    sum += matrix[i, i];
}

Console.WriteLine("Сумма диагональных элементов: " + sum);

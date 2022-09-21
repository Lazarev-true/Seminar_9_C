// Напишите программу, которая заполнит 
// спирально двумерный массив 4 на 4. 

Console.Write("Введите размер квадратной матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[size, size];
int numbers = 1;
int lineColumn = size;
int finalIndex = lineColumn - 1;
int initialIndex = 1;
int N = size - size / 2;

for (int i = 0; i < N; i++)
{
    Print1(array, i, lineColumn);
    Print2(array, finalIndex, lineColumn, initialIndex, 1);
    Print3(array, finalIndex, i);
    Print4(array, i, i, finalIndex - 1, -1);
    
    lineColumn--;
    finalIndex--;
    initialIndex++;
}

void Print1(int[,] arr, int j, int k)
{
    for (int i = j; i != k; i++)
    {
        arr[j, i] = numbers;
        numbers++;
    }
}
void Print2(int[,] arr, int j, int k, int n, int count)
{
    for (int i = n; i != k; i += count)
    {
        arr[i, j] = numbers;
        numbers++;
    }
}
void Print3(int[,] arr, int j, int k)
{
    for (int i = j - 1; i >= k; i--)
    {
        arr[j, i] = numbers;
        numbers++;
    }
}
void Print4(int[,] arr, int j, int k, int n, int count)
{
    for (int i = n; i > j; i += count)
    {
        arr[i, j] = numbers;
        numbers++;
    }
}

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if(array[i, j] < 10)
            Console.Write("{0} ", "0" + array[i, j]);
        else
            Console.Write("{0} ", array[i, j]);
    }
    Console.WriteLine();
}

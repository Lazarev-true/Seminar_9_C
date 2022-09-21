// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

Console.Write("Введите количество строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];

Random rand = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = rand.Next(50);
    }
}
Print(array);
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = j + 1; k < m;  k++)
        {
            if(array[i, j] < array[i, k])
            {
                int tmp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = tmp;
            }    
        }
    }
}
Print(array);
void Print(int[,] arr)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write("{0} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}
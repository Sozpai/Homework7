//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
Console.WriteLine("введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,]arr=new int [n, m];
double []sum=new double [m];
Random ran = new Random();

for (int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
    {
        arr[i, j] = ran.Next(0, 100);

        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int i=0; i<m; i++)
{
    for(int j=0; j<n; j++)
    {
        sum[i] += arr[j, i];
    }
}

for (int i=0; i<m; i++)
{
    Console.WriteLine("Среднее арифметическое:" + (sum[i] / n)  + " ");
}
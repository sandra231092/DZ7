//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[,]{{1,7,9,6},{6,8,4,3},{8,1,2,3}};
Console.Write("Среднее арифметическое элементов в каждом столбце: ");

for(int i = 0; i < matrix.GetLength(1); i++)
{
    double sum = 0;
    for(int j = 0; j < matrix.GetLength(0); j++)
    {
        sum = sum + matrix[j,i];
    }
    double aver = sum/matrix.GetLength(0);
    if(i > 0)
    {
        Console.Write("; ");
    }
    Console.Write($"{aver:f1}");
}
Console.WriteLine(".");
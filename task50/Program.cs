//Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет

int[,] matrix = new int[,]{{1,5,3,2},{4,3,4,3},{8,4,3,6}};

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
}
Console.Write("Введите индекс строки и колонки через пробел: ");
string arg = Console.ReadLine();
string[] argElements = arg.Split( );

if(argElements.Length != 2)
{
    Console.WriteLine("Необходимо ввести два значения.");
    return;
}

int row = Convert.ToInt32(argElements[0]);
int column = Convert.ToInt32(argElements[1]);

if(row < 0 || row >=matrix.GetLength(0) || column < 0 || column >= matrix.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет.");
    return;
}

Console.WriteLine($"В данной матрице, в строке {row}, в колонке {column} находится значение: {matrix[row,column]}");
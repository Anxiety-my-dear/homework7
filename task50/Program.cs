Console.Clear();

Console.Write("Введите число строк массива : ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов массива : ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, colums, min, max);

PrintArray(array);

void PrintArray(int[,] arr) {
   for (int i = 0; i < arr.GetLength(0); i++)
   {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] >= 0 ? $"  {arr[i,j]}" : $" {arr[i,j]}");
        }    
        Console.WriteLine();
   }
}

int[,] FillArray(int rowArray, int colArray, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rowArray, colArray];
    for (int i = 0; i < rowArray; i++)
        for (int j = 0; j < colArray; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    return resultArray;
}
Console.WriteLine("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i < array.GetLength(0) && j < array.GetLength(1)) Console.WriteLine(array[i,j]);
else Console.WriteLine($"{i-1},{j-1} -> такого числа в массиве нет");

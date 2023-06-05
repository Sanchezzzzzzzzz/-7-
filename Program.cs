//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void CreateArray(double[,] array){
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble();
        }
    }
}
void PrintArray(double[,] array){
     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int PrintMes(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int m = PrintMes("Введите количество строк:");
int n = PrintMes("Введиет количество столбцов:");
double[,] matrix = new double[m, n];
CreateArray(matrix);
PrintArray(matrix);



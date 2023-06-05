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
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
void MakeArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}
void PrintArray1(int[,] array){
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
int rows = PrintMes("Введите позицию строки:");
int colums = PrintMes("Введите позицию столбца");
int[,] matrix1 = new int[3,4];
MakeArray(matrix1);
PrintArray1(matrix1);
if((rows-1<matrix1.GetLength(0) && colums-1<matrix1.GetLength(1)) || (rows-1<1 && colums-1<1)){
    Console.WriteLine($"Элемент под позицией {rows}, {colums}: {matrix1[rows-1,colums-1]}");
} 
else{
    Console.WriteLine("Вы вышли за пределы массива");
}
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void InputArray(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}
void MeanArifm(double[,] array){
    for (int j = 0; j < array.GetLength(1); j++)
    {   
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum+=array[i, j];    
        }
        Console.WriteLine($"Среднее арифметическое {j} столбца: {sum/array.GetLength(1)}");
        Console.WriteLine();
    }
}
double[,] array222 = new double[3, 4];
InputArray(array222);
PrintArray(array222);
MeanArifm(array222);



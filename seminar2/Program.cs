// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Задача 47");

void FillWriteArray (Double[,] arr)
{
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble();
            Console.Write("{0,6:F2}", arr[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: "); int m = int.Parse(Console.ReadLine()!); 
Console.Write("Введите количество столбцов массива: "); int n = int.Parse(Console.ReadLine()!);
Double[,] array = new Double [m, n];
FillWriteArray(array);


//Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец),
//проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том,
//что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.
Console.WriteLine();
Console.WriteLine("Задача 50");

    Console.Write("Введите номер строки массива: "); int a = int.Parse(Console.ReadLine()!); 
    Console.Write("Введите номер столбца массива: "); int b = int.Parse(Console.ReadLine()!);
    if (a-1 <= m && b-1 <= n) { Console.WriteLine("Такой элемент найден: "+"{0,6:F2}", array[a-1, b-1]); }
    else Console.WriteLine("Такой элемент не найден.");



//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine();
Console.WriteLine("Задача 52");

Console.Write("Введите количество строк массива: "); int c = int.Parse(Console.ReadLine()!); 
Console.Write("Введите количество столбцов массива: "); int d = int.Parse(Console.ReadLine()!);
int[,] array2 = new int [c, d];

//заполнение
for (int i=0; i < array2.GetLength(0); i++)
{
    for (int j=0; j < array2.GetLength(1); j++)
    {
        Console.Write("Задайте элемент массива: ");
        array2[i, j] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine();
}
    
//вывод
for (int i=0; i < array2.GetLength(0); i++)
{
    for (int j=0; j < array2.GetLength(1); j++)
    {
        Console.Write($"{array2[i, j]} ");
    }
    Console.WriteLine();
}

//среднее арифметическое
for (int j=0; j < array2.GetLength(1); j++)
{
    double Sum = 0;
    double SrAr = 0.0;
    double Count = c;
    for (int i=0; i < array2.GetLength(0); i++)
    {
        Sum += array2[i, j];
    }
    SrAr = (Sum / Count) + (Sum % Count) - 1;
    Console.WriteLine($"Среднее арифмеическое {j+1} столбца: {SrAr:F2}");
}
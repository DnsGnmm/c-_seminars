//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine();
Console.WriteLine("Задача 54");
Console.Write("Введите количество строк массива: "); int row = int.Parse(Console.ReadLine()!); 
Console.Write("Введите количество столбцов массива: "); int column = int.Parse(Console.ReadLine()!);
int[,] array = new int [row, column];
//int[,] array2 = array1;

//метод вывода
void WriteArray (int[,] arr)
{
for (int i=0; i < arr.GetLength(0); i++)
{
    for (int j=0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
}

//медот сортировки по убыванию
void SortArrayRow (int[,] arr)
{
    for (int i=0; i < arr.GetLength(0); i++)
    {
        for (int j=0; j < arr.GetLength(1); j++)
        {
            for (int iter=0; iter < arr.GetLength(1)-1; iter++)
            {
                if (arr[i,iter] < arr[i,iter+1])
                {
                    int clipboard = arr[i,iter+1];
                    arr[i,iter+1] = arr[i,iter];
                    arr[i,iter] = clipboard;
                }
            }
        }
    }
}


//заполнение
for (int i=0; i < array.GetLength(0); i++)
{
    for (int j=0; j < array.GetLength(1); j++)
    {
        Console.Write("Задайте элемент массива: ");
        array[i, j] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine();
}

Console.WriteLine("Изначальный массив:");
WriteArray(array);

SortArrayRow (array);

Console.WriteLine("Отсортированный массив массив:");
WriteArray(array);


//Задача 57: Составить частотный словарь элементов двумерного массива.
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Console.WriteLine();
Console.WriteLine("Задача 57");

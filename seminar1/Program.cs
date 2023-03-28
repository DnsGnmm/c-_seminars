// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число A: "); int A = int.Parse(Console.ReadLine()!); 

Console.Write("Введите число B: "); int B = int.Parse(Console.ReadLine()!);

if (A>B) Console.Write($"{A}"+" больше чем "+$"{B}");

else Console.Write($"{B}"+" больше чем "+$"{A}");
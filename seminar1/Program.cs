// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите число A: "); int A = int.Parse(Console.ReadLine()!); 

Console.Write("Введите число B: "); int B = int.Parse(Console.ReadLine()!);

if (A>B) Console.Write($"{A}"+" больше чем "+$"{B}");

else Console.Write($"{B}"+" больше чем "+$"{A}");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число C: "); int C = int.Parse(Console.ReadLine()!); 

Console.Write("Введите число D: "); int D = int.Parse(Console.ReadLine()!);

Console.Write("Введите число E: "); int E = int.Parse(Console.ReadLine()!);

int count = 0; int max = 0;

while (count < 2)
{
if (C > max) max = C;
if (D > max) max = D;
if (E > max) max = E;
count++;
};

Console.Write("Наибольшее - "+$"{max}");

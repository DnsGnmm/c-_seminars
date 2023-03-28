// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число A: "); int A = int.Parse(Console.ReadLine()!); 

Console.Write("Введите число B: "); int B = int.Parse(Console.ReadLine()!);

if (A>B) Console.Write($"{A}"+" больше чем "+$"{B}");

else Console.WriteLine($"{B}"+" больше чем "+$"{A}");


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

Console.WriteLine("Наибольшее - "+$"{max}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка(number%2==0)).

Console.Write("Введите число: "); int F = int.Parse(Console.ReadLine()!);

if (F%2 == 0) Console.Write($"{F}"+" - четное");

else Console.WriteLine($"{F}"+" - нечетное");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: "); int N = int.Parse(Console.ReadLine()!);

int count2 = 2;

while (count2 < N)
{
    if (count2%2 == 0) Console.Write($"{count2}"+", ");
    count2 ++;
};
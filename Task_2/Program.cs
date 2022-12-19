// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
Console.Clear();

Console.Write ("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine()!);
Console.Write ("Введите второе число: ");
int Number2 = int.Parse(Console.ReadLine()!);
Console.Write ("Введите третье число: ");
int Number3 = int.Parse(Console.ReadLine()!);

int max = 0;

if (Number1>Number2)
{
    max = Number1;
}
else
{
    max = Number2;
}
if (max > Number3)
{
    Console.Write ($"max = {max}");
}
else
{
    max = Number3;
    Console.Write ($"max = {max}");
}
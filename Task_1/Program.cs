// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Пример a = 5; b = 7 -> max = 7
Console.Clear();

Console.Write ("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine()!);
Console.Write ("Введите второе число: ");
int Number2 = int.Parse(Console.ReadLine()!);

if (Number1>Number2)
{
    Console.Write ($"max = {Number1}");
}
else
{
    Console.Write ($"max = {Number2}");
}
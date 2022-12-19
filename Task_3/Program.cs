// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Пример: 4 -> да
// -3 -> нет
Console.Clear();

Console.WriteLine("Введите число: ");
int number=int.Parse(Console.ReadLine()!);
if (number % 2 == 0)
{
    Console.Write($"Число {number} чётное");
}
else
{
    Console.Write($"Число {number} не является чётным");
}
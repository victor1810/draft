// Напишите программу на C # Sharp для отображения таблицы умножения заданного целого числа.

Console.Write("Введите число для расчёта: ");
int num = int.Parse(Console.ReadLine());
int count = 1;

while (count < 11)
{
    Console.WriteLine($"{num} x {count} = {num * count}");
    count++;
}

// Напишите программу на C # Sharp, чтобы отобразить куб числа до заданного целого числа.

int num = 1;

while (num < 6)
{
    int cube = (num * num * num);
    Console.Write($"{cube}, ");
    num++;
}

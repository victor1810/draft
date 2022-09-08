/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Write("Введите число для расчёта: ");
// int num = int.Parse(Console.ReadLine()!);
// int count = 1;

// while (count < 11)
// {
//     Console.WriteLine($"{num} x {count} = {num * count}");
//     count++;
// }

/* Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел. */

// int a = new Random().Next(100);
// int b = new Random().Next(100);
// int c = new Random().Next(100);

// int max = a;

// if (b > max)
//     max = b;
// if (c > max)
//     max = c;
// Console.Write($"a = {a}, b = {b}, c = {c}. max ->  {max}");
/*
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125          */

// int num = new Random().Next(10);
// Console.Write($"{num} -> ");
// for (int i = 1; i <= num; i++) Console.Write($"{i * i * i} ");


/* **Задача 33:** Задайте массив. Напишите программу,
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да                         */

/* **Задача 35:** Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
[5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0 [10, 11, 12, 13, 14] -> 5        */


/* Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16                                                 */

// int A = new Random().Next(10);
// int B = new Random().Next(5);

// int power = 1;
// for (int i = 1; i <= B; i++)
// {
//     power *= A;
// }

// Console.WriteLine($"A = {A}; B = {B} -> {power}");




/* Задача 27: Напишите программу, которая принимает
на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12                                       */


// int num = new Random().Next(10000);

// int SumNum(int num)
// {
//     int count = Convert.ToString(num).Length;
//     int step = 0;
//     int sum = 0;

//     for (int i = 0; i < count; i++)
//     {
//         step = num % 10;
//         sum = sum + step;
//         num = num / 10;
//     }
//     return sum;
// }
// int sumNum = SumNum(num);
// Console.WriteLine($"Сумма цифр в числе {num} -> {sumNum}");


/* Задача 29: Напишите программу, которая задаёт
массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]                        */

/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0                           */

// int[] array = { new Random().Next(-99, 100),
//                 new Random().Next(-99, 100),
//                 new Random().Next(-99, 100),
//                 new Random().Next(-99, 100)};
// int sum = 0;
// for (int i = 0; i < array.Length; i++)
//     if (i % 2 != 0)
//         sum = sum + array[i];


// Console.Write($"[{array[0]}, {array[1]}, {array[2]}, {array[3]}] -> {sum}");


/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76                                             */

// int[] array = { new Random().Next(-99, 100),
//                 new Random().Next(-99, 100),
//                 new Random().Next(-99, 100),
//                 new Random().Next(-99, 100),
//                 new Random().Next(-99, 100)};

// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 10);

// int max = array[0];
// int min = array[0];

// for (int i = 1; i < array.Length; i++)
// {
//     if (max < array[i])
//         max = array[i];

//     if (min > array[i])
//         min = array[i];
// }
// int diff = max - min;
// Console.Write($"[{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}] ");
// Console.WriteLine($"-> max({max}) - min({min}) = {diff}");


// double a, b, c;
// double x, y;
// //Пользователь вводит стороны прямоугольника и квадрата
// Console.Write("Введи в 1-ю сторону прямоугольника: ");
// a = Convert.ToDouble(Console.ReadLine()!);
// Console.Write("Введи в 2-ю сторону прямоугольника: ");
// b = Convert.ToDouble(Console.ReadLine()!);
// Console.Write("Введи сторону квадрата: ");
// c = Convert.ToDouble(Console.ReadLine()!);
// Console.WriteLine();
// //Условия вывода значений
// if ((a < c) | (b < c))
//     Console.WriteLine("Невозможно вместить квадрат. Одна из сторон прямоугольника меньше стороны квадрата");
// else
// {
//     x = (a - a % c) / c;
//     y = (b - b % c) / c;
//     Console.WriteLine("В прямоугольнике помещается: {0} квадратов", x * y);
// }
// Console.ReadKey();


// Дано расстояние в метрах. Найти число полных километров в нем.

// Console.Write("Введите расстояние в метрах -> ");
// double metre = Convert.ToDouble(new Random().Next(1, 10000));

// double kilometer = ((metre - metre % 1000) / 1000);

// Console.WriteLine($"В {metre} метрах находится {kilometer} киллометров");


// Функция рандомного набора массива
// int[] CreatedArray(int size, int min = 0, int max = 100)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//         array[i] = new Random().Next(min, max + 1);
//     return array;
// }

// foreach (var _el in CreatedArray(8))
//     Console.Write($"{_el} ");

/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3                         */

// Console.Write($"Введи несколько чисел -> ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] massiveNumbers = new int[m];

// void InputNumbers(int m)
// {
//     for (int i = 0; i < m; i++)
//     {
//         Console.Write($"Введи {i + 1} число: ");
//         massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// int Comparison(int[] massiveNumbers)
// {
//     int count = 0;
//     for (int i = 0; i < massiveNumbers.Length; i++)
//     {
//         if (massiveNumbers[i] > 0) count += 1;
//     }
//     return count;
// }

// InputNumbers(m);

// Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");


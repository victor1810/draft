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

// Console.WriteLine($"\nЗадача 29. Ряд чисел преобразует в массив");
// Console.Write("Введите ряд чисел, разделенных запятой : ");
// string? seriesOfNumbers = Console.ReadLine();

// seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// // функция удаления пробелов из строки 
// string RemovingSpaces(string series)
// {
//     string seriesNew = "";
//     for (int i = 0; i < series.Length; i++)
//     {
//         if (series[i] != ' ')
//         {
//             seriesNew += series[i];
//         }
//     }
//     return seriesNew;
// }

// //  функция  проверки на правильность ввода 
// void СheckNumber2(int series)
// {

//     if (series == '0' || series == '1' || series == '2'
//     || series == '3' || series == '4' || series == '5' || series == '6'
//     || series == '7' || series == '8' || series == '9' || series == ','
//     || series == '-')
//     {
//     }
//     else
//     {
//         Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

//     }
// }

// // функция  создания и заполнения массива из строки
// int[] ArrayOfNumbers(string seriesNew)
// {

//     int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

//     int j = 0;

//     for (int i = 0; i < seriesNew.Length; i++)
//     {
//         string seriesNew1 = "";

//         while (seriesNew[i] != ',' && i < seriesNew.Length)
//         {
//             seriesNew1 += seriesNew[i];
//             СheckNumber2(seriesNew[i]);
//             i++;
//         }
//         arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
//         if (i < seriesNew.Length - 1)
//         {
//             arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();    // добавляет новый нулевой элемент в конец массива
//         }
//         j++;
//     }
//     return arrayOfNumbers;
// }

// // функция  вывода массива на печать 
// void PrintArry(int[] coll)
// {
//     int count = coll.Length;
//     int index = 0;
//     Console.Write("[");
//     while (index < count)
//     {
//         Console.Write(coll[index]);
//         index++;
//         if (index < count)
//         {
//             Console.Write(", ");
//         }
//     }
//     Console.Write("]");
// }


// string seriesNew = RemovingSpaces(seriesOfNumbers);

// int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

// PrintArry(arrayOfNumbers);

// Console.WriteLine($"Введите восемь чисел через запятую ");

// int[] array = new int[8];
// string? numbers = Console.ReadLine();
// int step = 0;

// for (int i = 0; i < 8; i++)
//     array[step] = numbers[step];
// step++;

// Console.Write(array[5]);

// Console.Write("Введите восемь чисел, для создания массива -> ");
// int numbers = Convert.ToInt32(Console.ReadLine());
// int[] result = ArrayInit(numbers);

// int[] ArrayInit(int numbers)
// {
//     // int[] array = new int[8];//задаю размер массива
//     // string? numbers = Console.ReadLine();//Создаете ОДИН экземпляр класса Random
//     int step = 0;
//     for (int i = 0; i < 8; i++)//циклом прохожу по массиву и заполняю его случайными значениями
//     {
//         int[] array = { step };
//         step++;
//     }
//     return array[];
// }

// Console.WriteLine($"[{string.Join(", ", result)}]"); //Выводите массив
// Console.Write($"{numbers}");


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



int[] CreatedArray(int size, int min = 0, int max = 100)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

foreach (var _el in CreatedArray(8))
    Console.Write($"{_el} ");




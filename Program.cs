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


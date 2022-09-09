/* Известна стоимость монитора, системного блока, клавиатуры и мыши.
Сколько будут стоить 3 компьютера из этих элементов? N компьютеров? */

Console.WriteLine();
int monitor = InputNumbers("Введите цену на монитор: ");
int system = InputNumbers("Введите цену на системный блок: ");
int keyboard = InputNumbers("Введите цену на клавиатуру: ");
int mouse = InputNumbers("Введите цену на компьютерную мышь: ");
int n = InputNumbers("Введите количество компьютеров: ");
Console.WriteLine();

int set = monitor + system + keyboard + mouse;

Console.WriteLine($"Цена за 1 компьютер = {set} денег");
Console.WriteLine($"Цена за {n} компьютеров = {n * set} денег\n");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
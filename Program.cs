/* Известна стоимость монитора, системного блока, клавиатуры и мыши.
Сколько будут стоить 3 компьютера из этих элементов? N компьютеров? */

int monitor = InputNumbers();
int system = InputNumbers();
int keyboard = InputNumbers();
int mouse = InputNumbers();
int n = InputNumbers();
Console.WriteLine();

int set = monitor + system + keyboard + mouse;

Console.WriteLine($"Цена за 1 компьютер = {set} денег");
Console.WriteLine($"Цена за {n} компьютеров = {n * set} денег\n");

int InputNumbers(string, )
{
    Console.Write();
    int output = new Random().Next(100, 100000);
    return output;
}

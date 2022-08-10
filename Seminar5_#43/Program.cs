// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//***********************
bool InputDannyh(string text, out double? val1, out double? val2)
{
    val1 = null;
    val2 = null;
    Console.Write($"{text} через пробел: ");
    double[] array = Console.ReadLine().Split(' ', 2, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
    if (array.Length < 2)
    {
        Console.WriteLine("Вводимые данные должны состоять из 2х чисел, разделенных пробелом!!!");
        Console.Write("Хотите повторно ввести данные? (y - да): ");
        string otvet = Console.ReadLine();
        if (otvet == "y" || otvet == "Y")
        {
            return InputDannyh(text, out val1, out val2);
        }
        return false;
    }
    val1 = array[0];
    val2 = array[1];
    return true;
}

//***********************
Console.Write("Программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");
Console.WriteLine("");

double? k1, k2, b1, b2;

if (!InputDannyh("Введите угловые коэффициенты двух прямых", out k1, out k2) || !InputDannyh("Введите значения пересечения двух прямых с осью y", out b1, out b2))
    Console.WriteLine("Расчет прерван из-за отказа ввода данных");
else
{
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые параллельны и совпадают");
        }
        else
        {
            Console.WriteLine("Прямые параллельны и не имеют пересечений");
        }
    }
    else
    {
        double? x = (b2 - b1) / (k1 - k2);
        double? y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения двух прямых ({x};{y})");
    }
}
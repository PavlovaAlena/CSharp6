// Задача 41.  Пользователь вводит с клавиатуры M чисел в одну линию (не используем Enter). Числа разделены пробелами. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//***********************
Console.Write("Программа  позволяет пользователю вводить с клавиатуры M чисел в одну линию через пробел и считает, сколько чисел больше 0 было введено.");
Console.WriteLine("");

Console.Write("Введите числа через пробел ");

int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

/*string[] arrIn = Console.ReadLine().Split();
int[] arr = new int[arrIn.Length];
int icount = 0;
foreach (string i in arrIn)
{
    if (int.TryParse(i, out int itemp))
    {
        arr[icount] = Convert.ToInt32(itemp);
        icount ++;
    }
}
 */

int count = ArraySearch(array);

Console.WriteLine("В массиве " + '[' + string.Join(", ", array) + ']' + " количество положительных чисел = " + count);

//***********************
int ArraySearch(int[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
        {
            cnt++;
        }
    }
    return cnt;
}

// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int res_proiz = MultiplyDigit(number);
Console.WriteLine($"Произведение чисел диапозона от 1 до {number} = {res_proiz}");



int MultiplyDigit(int num)
{
    int proiz = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            proiz *=i;
        }
        proiz *= i;
    }
    return proiz;
}
// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

Console.WriteLine("Введите положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int res_sum = CountNumber(number);
Console.WriteLine($"Колличество цифр в {number} = {res_sum}");



int CountNumber(int num){
    
    if (num ==0) return 1;
    int count = 0;
   while (num != 0)
   {
  num/=10;
  count++;
   }
   return count;
    {
        
    }
}
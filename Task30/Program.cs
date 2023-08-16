// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] array = new int[8];
// int[] array_1 = (3, 7, 6, 9, 2);
// array[0] = 4556;
// array[7] = 4555;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = i * i;
//     Console.WriteLine(array[i] + "");
// }
int[] array = new int[8];
FillArray(array);
PrintArray(array);


void FillArray(int[] arr)
{ Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }

}

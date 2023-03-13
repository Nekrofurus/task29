// Задача 29
// Напишите программу, которая задает массив из 8 элементов и выводит их на экран
Console.Write("Введите длинну массива = ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение = ");
int max = Convert.ToInt32(Console.ReadLine());
int[] CreateRandomArray (int length, int min, int max)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}


void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"{array[i]}, "); 
    } 
     Console.Write($"{array[array.Length - 1]}"); 
     Console.Write("]");
}
int[] array = CreateRandomArray(length, min, max);
PrintArray(array);
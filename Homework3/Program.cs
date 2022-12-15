//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

// Console.Write("Введите ряд чисел, разделенных запятой : ");
// string seriesOfNumbers = Console.ReadLine();

//Решение 1:
// string[] numbers = new string[]{seriesOfNumbers};
// PrintArray(numbers);
// void PrintArray(string[] array)
// {
//     Console.Write("[");
//     for (var i = 0; i < array.Length-1; i++)
//     {
//         Console.Write($"{array[i]},");
//     }
//     Console.Write(array[array.Length-1]);
//     Console.Write("]");
// }

Console.Write("Введите размер массива : ");
int num = int.Parse(Console.ReadLine());

int[] result = CreareArray(num);
PrintArray(result);

int[] CreareArray(int num)
{
    int[] array = new int [num];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Введите " + (i+1) + " число: ");
            array[i] = int.Parse(Console.ReadLine()); 
        }
Console.Write("Ваш массив из " + (num) + " переменных: ");
return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}
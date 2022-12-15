// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

       Console.WriteLine("Введите число : ");
bool isParsed = false;
int number = 0;
    while (isParsed == false)
    {
    isParsed = int.TryParse(Console.ReadLine(), out number);
        if (isParsed == false)
        {
        Console.WriteLine("Пиши число !");
        }
    }

int num = number;

int SumNumber(int num){
    
int size = Convert.ToString(num).Length;
int move = 0;
int result = 0;

    for (int i = 0; i < size; i++){
      move = num - num % 10;
      result = result + (num - move);
      num = num / 10;
    }
   return result;
  }

int sumNumber = SumNumber(num);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);
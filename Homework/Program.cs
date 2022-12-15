// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
       Console.WriteLine("Введите число A: ");
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


       Console.WriteLine("Введите число B: ");
bool isParsedSecond = false;
int numberSecond = 0;
    while (isParsedSecond == false)
    {
    isParsedSecond = int.TryParse(Console.ReadLine(), out numberSecond);
        if (isParsedSecond == false)
        {
        Console.WriteLine("Пиши число !");
        }
    }
int numberA = number;
int numberB = numberSecond;

    int degree = Degree(numberA, numberB);
    Console.WriteLine("Ответ: " + degree);

int Degree(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    return result;
}


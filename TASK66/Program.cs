// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число N:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число M:");
int numberN = Convert.ToInt32(Console.ReadLine());

void RealSum(int numberM, int numberN, int sum)
{
  if (numberM > numberN)
  {
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
    return;
  }
  sum = sum + (numberM++);
  RealSum(numberM, numberN, sum);
}

RealSum(numberM, numberN, 0);
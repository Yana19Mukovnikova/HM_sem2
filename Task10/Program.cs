//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int SecondNum(string mes)
{
   System.Console.WriteLine(mes);
   string meaning = Console.ReadLine();
   int result = Convert.ToInt32(meaning);
   return result;
}
int num = SecondNum("Введите трехзначное число:");
if (num < 100 || num >= 1000)
{
    System.Console.WriteLine("Число не является трехзначным, повторите попытку:");
    return;
} 
System.Console.WriteLine($"Ваше число: {num}");
int second = num / 10 % 10;
System.Console.WriteLine($"Вторая цифра: {second}");

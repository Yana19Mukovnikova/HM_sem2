// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int ThirdNum(string mes)
{
   System.Console.WriteLine(mes);
   string meaning = Console.ReadLine();
   int result = Convert.ToInt32(meaning);
   return result;
}
int GitThirdNum(int num)
{
    while (num < 100 || num >= 1000)
    {
        num /= 10;
    }
    return num % 10;
}
bool CheckNum(int num)
{
    if (num < 100)
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}
int num = ThirdNum("Ваше число:");
if (CheckNum(num))
{
    System.Console.WriteLine("Третья цифра:");
    System.Console.WriteLine(GitThirdNum(num));
}


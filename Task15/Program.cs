//Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
int day;
{
System.Console.WriteLine("Введите день недели (1-7):");
day = Convert.ToInt32(System.Console.ReadLine());

    if (day == 6 || day == 7)
    {
       System.Console.WriteLine("Выходной день"); 
    }
    else
    {
        System.Console.WriteLine("Будний день");
    }
}



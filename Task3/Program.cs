/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int day = GetDigit();
System.Console.WriteLine(WeekdaysOrWeekend(day));

int GetDigit()
{
    System.Console.Write("Введите цифру от 1 до 7: ");
    int d = int.Parse(Console.ReadLine());
    return d;
}

int WeekdaysOrWeekend(int day)
{
    if (day <= 5)
    {
        System.Console.WriteLine("И снова рабочие будни(((");
    }
    else if (day > 5 && day <= 7)
    {
        System.Console.WriteLine("Ура, выходной!!!");
    }
    return day;
}

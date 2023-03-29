/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int a = GetRandom();
System.Console.WriteLine(a);
System.Console.WriteLine(GetSecondDigit(a));

int GetRandom()
{
    return new Random().Next(100, 1000);
}

int GetSecondDigit(int number)
{
    int FirstTwoNumbers = number / 10;
    int SecondDigit = FirstTwoNumbers % 10;
    return SecondDigit;
}
/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int a = GetRandom();
System.Console.WriteLine("Рандомное число: " + a);

int ThreeDigitNumber = GetThreeDigitNumber(a);
int ThirdDigit = PresenceThirdDigit(ThreeDigitNumber);
System.Console.WriteLine(ThirdDigit);


int GetRandom()
{
    System.Console.Write("Введите любое натуральное число: ");
    int N = int.Parse(Console.ReadLine());
    return new Random().Next(1, N);
}

int GetThreeDigitNumber(int n)
{
    int max = 1000;
    while (n >= max)
    {
        n = n / 10;
    }
    return n;
}

int PresenceThirdDigit(int x)
{
    x = GetThreeDigitNumber(x);
    int max = 100;

    if (x < max)
    {
        System.Console.Write("Третьей цифры нет - ");
    }
    else
    {
        x = x % 10;
    }
    return x;
}
// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

    int digit = number / 10;
    int res = digit % 10;
    Console.WriteLine(res);

    if(number < 100 || number >= 1000)
{
    Console.WriteLine("Введено не трехзначное число");
}
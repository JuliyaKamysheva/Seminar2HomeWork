// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите число a: ");
int numbera = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int numberb = Convert.ToInt32(Console.ReadLine());

if (numbera == numberb * numberb || numberb == numbera*numbera)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
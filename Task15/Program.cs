// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit >=1 && digit <= 5)
{
    Console.WriteLine("нет");
}

else if (digit ==6 || digit == 7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет такого дня недели");
}
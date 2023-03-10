// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число:");
int number5 =Convert.ToInt32(Console.ReadLine());
while (number5<10000 && number5>99999)
{
    Console.Write("Вы должны ввести пятизначное число:");
    number5 =Convert.ToInt32(Console.ReadLine());
}


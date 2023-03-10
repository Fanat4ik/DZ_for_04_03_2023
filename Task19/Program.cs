// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number5 =Convert.ToInt32(Console.ReadLine());
while (number5<10000 || number5>99999)
{
    Console.WriteLine("Вы должны ввести пятизначное число! ");
    number5 =Convert.ToInt32(Console.ReadLine());
}

String string5 = string.Empty;
string5 = number5.ToString();

for (int i = 0; i<=(string5.Length/2); i++)
{
    if (string5[i] != string5[string5.Length-1-i])
    {
        Console.Write("Введённое число не является палиндромом.");
        break;
    }
    if (i==string5.Length/2) Console.WriteLine("Введённое число является палиндромом!");
}


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number5 =Convert.ToInt32(Console.ReadLine());
//проверка, чтобы число состояло из 5 знаков
while (number5<10000 || number5>99999)
{
    Console.WriteLine("Вы должны ввести пятизначное число! ");
    number5 =Convert.ToInt32(Console.ReadLine());
}

// перевод int в String
String string5 = string.Empty;
string5 = number5.ToString();

// функция(метод) проверяет на палидром
void CheckPalindrom(String str)
{
        for (int i = 0; i<=(str.Length/2); i++)
    {
        if (str[i] != str[str.Length-1-i])
        {
            Console.Write("Введённое число не является палиндромом.");
            break;
        }
        if (i==str.Length/2) Console.WriteLine("Введённое число является палиндромом!");
    }
}

// вызов функции(метода) с подачей нашего числа в качестве аргумента в виде строки
CheckPalindrom(string5);

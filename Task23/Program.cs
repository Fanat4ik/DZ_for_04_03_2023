//Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//ввод N из консоли
Console.Write("введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

//функция(метод) для вывода таблицы кубов от 1 до N.
void TableCubes(int numN)
{
    Console.Write($"таблица кубов от 1 до {numN}: ");
    for(int i = 1; i <= numN; i++)
    {
        Console.Write($"{Math.Pow(i,3)} ");
    }
}

TableCubes(numberN);

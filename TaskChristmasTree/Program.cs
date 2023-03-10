// Задать N и вывести # до N елочкой 
// пример
// N = 3;
//   # 
//  ###
// N = 5
//     # 
//    ###
//   #####
// N = 7
//     # 
//    ###
//   #####
//  #######

// Двумерный цикл 
// Если у нас не должно быть # , то пишем пробел

// Примечание N - основание ёлки
void PrintWhitespace(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(" ");
    }
}

void PrintSharpe(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("#");
    }
}

//ввод N из консоли
Console.Write("введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
//проверка, чтобы основание ёлки было нечётным
while (numberN <= 0 || numberN%2 == 0 )
{
    Console.WriteLine("Вы должны ввести нечётное число! ");
    numberN =Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i <= numberN; i=i+2)
{
    PrintWhitespace((numberN - i) / 2);
    PrintSharpe(i);
    PrintWhitespace((numberN - i) / 2);
    Console.WriteLine();
}

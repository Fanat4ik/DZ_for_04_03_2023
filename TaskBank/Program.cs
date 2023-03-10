// У нас есть кеш - N $ , мы хотим сохранить его от инфляции,
//  кладем в банк и получаем раз в год M % ,
//   через сколько лет у нас получится купить квартиру за K $ ,
//   при том , что цена квартиры также растет на Q % 
// если этот процент больше или равен N ,
//   то вывести в консоль безысходность 

Console.Write("введите кеш$: ");
double cash = Convert.ToDouble(Console.ReadLine());
Console.Write("введите годовой процент%: ");
double incomePercent = Convert.ToDouble(Console.ReadLine());
Console.Write("введите цену на квартиру$: ");
double apartmentPrice = Convert.ToDouble(Console.ReadLine());
Console.Write("введите уровень годовой инфляции на квартиру%: ");
double inflation = Convert.ToDouble(Console.ReadLine());
double finance = cash;
double apartmentPriceActual = apartmentPrice;
double income = ((finance/100)*(100+incomePercent)) - finance;
double risePrice = ((apartmentPriceActual/100)*(100+inflation)) - apartmentPriceActual;

if (risePrice>income)
{
    Console.WriteLine("БЕЗЫСХОДНОСТЬ!");
}
else
{
    for (int year = 0; finance <= apartmentPriceActual; year++)
    {
        
        finance = finance + income;
        apartmentPriceActual=apartmentPriceActual+risePrice;
        if (finance >= apartmentPriceActual)
        {
            Console.WriteLine("Копить на квартиру: " + year + " лет");
        }
        income = ((finance/100)*(100+incomePercent)) - finance;
        risePrice= ((apartmentPriceActual/100)*(100+inflation)) - apartmentPriceActual;
    }
}

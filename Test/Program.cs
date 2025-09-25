//5

Console.WriteLine("\nЗадание 5");
{
    Console.Write("Введите стандартную цену: ");
    var priceInput = double.TryParse(Console.ReadLine(), out double normPrice);
    Console.WriteLine("Введите процент скидки: ");
    var percentInput = double.TryParse(Console.ReadLine(), out double percent);
    Console.WriteLine("Введите стоимость поездки: ");
    var tourInput = double.TryParse(Console.ReadLine(), out double tourPrice);

    var dutyprice = (1 - (percent * 0.01)) * normPrice;
    var solution = Math.Ceiling(tourPrice / (normPrice - dutyprice));
    Console.WriteLine($"Для окупа поездки вам понадобится {solution} бутылок ");

}

//6

Console.WriteLine("\nЗадание 6");
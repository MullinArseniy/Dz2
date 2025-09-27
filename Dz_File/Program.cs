using System;
using System;
using System.ComponentModel.Design;
using Dz_File.Enums;
using Dz_File.Structures;

namespace DzFile
{
    class Program
    {
        static void Main()
        {
            //1

            Console.WriteLine("Задание 1");
            Console.WriteLine($"Тип данных  Максимальное значение    Минимальное значение");
            Console.WriteLine($"byte        {byte.MaxValue,20}      {byte.MinValue,20}");
            Console.WriteLine($"sbyte       {sbyte.MaxValue,20}      {sbyte.MinValue,20}");
            Console.WriteLine($"short       {short.MaxValue,20}      {short.MinValue,20}");
            Console.WriteLine($"ushort      {ushort.MaxValue,20}      {ushort.MinValue,20}");
            Console.WriteLine($"int         {int.MaxValue,20}      {int.MinValue,20}");
            Console.WriteLine($"uint        {uint.MaxValue,20}      {uint.MinValue,20}");
            Console.WriteLine($"long        {long.MaxValue,20}      {long.MinValue,20}");
            Console.WriteLine($"ulong       {ulong.MaxValue,20}      {ulong.MinValue,20}");
            Console.WriteLine($"float       {float.MaxValue,20:E}      {float.MinValue,20:E}");
            Console.WriteLine($"double      {double.MaxValue,20:E}      {double.MinValue,20:E}");
            Console.WriteLine($"decimal     {decimal.MaxValue,20}      {decimal.MinValue,20}");
            Console.WriteLine($"bool        True                                     False");
            Console.WriteLine($"char        {char.MaxValue}           {char.MinValue}");





            //2

            Console.WriteLine("\nЗадание 2");
            {
                Console.Write("\nНапишите своё имя: ");
                var name = Console.ReadLine();
                Console.Write("Введите город: ");
                var city = Console.ReadLine();
                Console.Write("Введите возраст: ");
                var ageinput = int.TryParse(Console.ReadLine(),out int age);
                Console.Write("Введите Pin-код: ");
                var pincode = Console.ReadLine();
                accountData user1 = new accountData();
                user1.name = name;
                user1.city = city;
                user1.age = age;
                user1.pin = pincode;

                Console.WriteLine("\nДанные пользователя:");
                Console.WriteLine($"Имя: {user1.name}");
                Console.WriteLine($"Город: {user1.city}");
                Console.WriteLine($"Возраст: {user1.age}");
                Console.WriteLine($"Pin-код: {user1.pin}");



            }

            //3

            Console.WriteLine("\nЗадание 3");
            {
                Console.Write("\nВведите строку:");
                var stroka = Console.ReadLine();
                char[] finalstr = new char[stroka.Length];
                string strokaUp = stroka.ToUpper();
                string strokaLow = stroka.ToLower();
                for (int i = 0; i<stroka.Length; i++)

                {
                    if (stroka[i] == strokaUp[i])
                    {
                        finalstr[i] = strokaLow[i];
                    }

                    else
                    {
                        finalstr[i] = strokaUp[i];
                    }
                }
                Console.WriteLine(finalstr);

            }

            //4

            Console.WriteLine("\nЗадание 4");
            {
                Console.Write("Введите строку: ");
                var str1 = Console.ReadLine();
                Console.Write("Введите подстроку: ");
                var str2 = Console.ReadLine();
                int k = 0;
                for (int i = 0; i <= str1.Length - str2.Length; i++)
                {
                    if (str1.Substring(i, str2.Length) == str2)
                    {
                        k++;
                    }
                }
                Console.WriteLine($"Количество вхождений: {k}");
            }

            //5

            Console.WriteLine("\nЗадание 5");
            {
                Console.Write("Введите стандартную цену: ");
                var priceInput = double.TryParse(Console.ReadLine(), out double normPrice);
                Console.Write("Введите процент скидки: ");
                var percentInput = double.TryParse(Console.ReadLine(), out double percent);
                Console.Write("Введите стоимость поездки: ");
                var tourInput = double.TryParse(Console.ReadLine(), out double tourPrice);

                var dutyprice = (1 - (percent * 0.01)) * normPrice;
                var solution =Math.Ceiling( tourPrice / (normPrice - dutyprice));
                Console.WriteLine($"Для окупа поездки вам понадобится {solution} бутылок ");

            }

            //6

            Console.WriteLine("\nЗадание 6");
            {
                Drink vodka = new Drink();
                {
                    vodka.Name = "vodka";
                    vodka.PercentageOfAlcohole = 40;
                }

                Drink beer = new Drink();
                {
                    beer.Name = "beer";
                    beer.PercentageOfAlcohole = 5;
                }
                Drink wine = new Drink();
                {
                    wine.Name = "wine";
                    wine.PercentageOfAlcohole = 13;
                }
                Drink cola = new Drink();
                {
                    cola.Name = "cola";
                    cola.PercentageOfAlcohole = 0;
                }

                Student[] students = new Student[5];
                {

                    students[0] = new Student();
                    { students[0].Name = "Алексей"; students[0].Surname = "Иванов"; students[0].Id = Guid.Parse("1"); students[0].Birthdate = new DateTime(2007, 1, 1); students[0].AlcogolicCategory = AlcoholicType.A; students[0].DrinkVolume = 1; students[0].TypeDrink = vodka; }
                    students[1] = new Student();
                    { students[1].Name = "Миша"; students[1].Surname = "Дубин"; students[1].Id = Guid.Parse("2"); students[1].Birthdate = new DateTime(2007, 1, 2); students[1].AlcogolicCategory =AlcoholicType.B ; students[1].DrinkVolume = 2; students[1].TypeDrink = beer; }
                    students[2] = new Student();
                    { students[2].Name = "Гриша"; students[2].Surname = "Злобин"; students[2].Id = Guid.Parse("3"); students[2].Birthdate = new DateTime(2007, 1, 3); students[2].AlcogolicCategory = AlcoholicType.C; students[2].DrinkVolume = 1.5; students[2].TypeDrink = wine; }
                    students[3] = new Student();
                    { students[3].Name = "Арсений"; students[3].Surname = "Силантьев"; students[3].Id =Guid.Parse("4"); students[3].Birthdate = new DateTime(2007, 1, 4); students[3].AlcogolicCategory = AlcoholicType.D; students[3].DrinkVolume = 1; students[3].TypeDrink = cola; }
                    students[4] = new Student();
                    { students[4].Name = "Ваня"; students[4].Surname = "Филиппов"; students[4].Id = Guid.Parse("5"); students[4].Birthdate = new DateTime(2007, 1, 5); students[4].AlcogolicCategory = AlcoholicType.A; students[4].DrinkVolume = 3; students[4].TypeDrink = vodka; }

                    double allVolume = 0;
                    double allAlcohole = 0;


                    foreach (var student in students)
                    {
                        allVolume += student.DrinkVolume;
                        allAlcohole += student.DrinkVolume*(student.TypeDrink.PercentageOfAlcohole/100);
                    }

                    foreach(var student in students)
                    {
                        double alcoholeForStudent = student.DrinkVolume * (student.TypeDrink.PercentageOfAlcohole / 100);
                        double alcoholePercentOfAll = (alcoholeForStudent/allAlcohole)*100;
                        double fluidVolumeOfAll = (student.DrinkVolume / allVolume) * 100;

                        Console.WriteLine($"\n{student.Name} {student.Surname}");
                        Console.WriteLine($"Объём алкоголя {alcoholeForStudent}л, что составляет {alcoholePercentOfAll}% от общего объёма алкоголя");
                        Console.WriteLine($"Объём жидкости {student.DrinkVolume}л, что составляет {fluidVolumeOfAll}% от общего объёма выпитого");
                        Console.WriteLine(student.TypeDrink.PercentageOfAlcohole);
                    }

                    Console.WriteLine($"\n\nОбщий объём алкоголя: {allAlcohole}");
                    Console.WriteLine($"Общий объём жидкости: {allVolume}");



                }
            }
        }   
    }
}














            

















 



   
        
         



         




       
        

        
           


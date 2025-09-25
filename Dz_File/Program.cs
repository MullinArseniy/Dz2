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
                string? stroka = Console.ReadLine();
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

            }












        }
    }
}


   
        
         



         




       
        

        
           


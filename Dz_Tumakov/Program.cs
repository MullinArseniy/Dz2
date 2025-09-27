using System;
using Dz_Tumakov.Enums;
using Dz_Tumakov.Structures;
namespace Dz_Tumakov
{
    class Programm
    {
        static void Main()
        {
            
            //1
            
            Console.WriteLine("Задание 1 - ( Вывести тип банковского счёта )");
            {
                BankAccountType current = BankAccountType.Сберегательный;
                Console.WriteLine($"Вид банковского счёта: {current}");
            }


            //2

            Console.WriteLine("\nЗадание 2 - ( Структура данных банковского счёта )");
            {
                BankAccountType client1Type = (BankAccountType)1;
                BankAccount client1 = new BankAccount();
                client1.Id = 12345;
                client1.Type = client1Type ;
                client1.Balance = 150;

                Console.WriteLine("\nИнформация о банковском счёте");
                Console.WriteLine($" Номер счёта: {client1.Id}");
                Console.WriteLine($" Тип счёта: {client1.Type}");
                Console.WriteLine($" Баланс: {client1.Balance}");
            }

            //3

            Console.WriteLine("\nЗадание 3 - ( Структура работника Вуза )");
            {
                Console.Write("\nНапишите своё имя: ");
                var name = Console.ReadLine();
                Console.WriteLine("Выберите номер ВУЗа: 1)КГУ  2)КАИ  3)КХТИ ");
                var univ = int.Parse(Console.ReadLine());
                Worker account1 = new Worker();
                account1.Name = name;
                account1.University = (University)(univ-1);

                Console.WriteLine("\nДанные рабочего");
                Console.WriteLine($" Имя: {account1.Name}");
                Console.WriteLine($" Университет: {account1.University}");

            }
        }

    }
}


using System;

namespace LoopApp
{
    class Program
    {
        static void Main()
        {
            Talk();
        }
        
        static void Talk()
        {
            Console.WriteLine("Добро пожаловать в говорилку Bonetti giga chat v1.1, для начала диалога введите 'привет' или 'пока'");
            string str = Console.ReadLine();
            if (str == "привет")
            {
                Console.WriteLine("Привет! Как у тебя дела?");
                str = Console.ReadLine();
                if (str == "хорошо")
                {
                    Console.WriteLine("Как тебя зовут?");
                    str = Console.ReadLine();
                    if (str == $"{str}")
                    {
                        Console.WriteLine($"Приятно познакомится {str}!");
                        Age();
                    }
                    else
                    {
                        Console.WriteLine("Введи имя");
                    }
                }
                else if (str == "плохо")
                {
                    Console.WriteLine("Котик не грусти :)");
                }
                else
                {
                    Console.WriteLine("Я тебя не понимаю");
                }
            }
            else if (str == "пока")
            {
                Console.WriteLine("Пока!");
            }
            else
            {
                throw new Exception("Скажите Привет или Пока!");
            }
        }

        static void Age()
        {
            Console.WriteLine("Сколько тебе лет?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 10)
            {
                Console.WriteLine("Иди Дневник заполняй!");
            }
            else if (age > 10)
            {
                Console.WriteLine("Долгих лет тебе товарищ!");
            }
            else
            {
                Console.WriteLine("Ты шо робот?");
            }
        }
    }
}


using System;

namespace LoopApp
{
    class Program
    {
        static void Main()
        {
            Talking();
        }
        
        static void Talking()
        {
            Console.WriteLine("Добро пожаловать в говорилку Bonetti giga chat v1.1, для начала диалога введите 'привет' или 'пока'");
            string message = Console.ReadLine();
            if (message == "привет")
            {
                Console.WriteLine("Привет! Как у тебя дела?");
                message = Console.ReadLine();
                if (message == "хорошо")
                {
                    Console.WriteLine("Как тебя зовут?");
                    message = Console.ReadLine();
                    if (message == $"{message}")
                    {
                        Console.WriteLine($"Приятно познакомится {message}!");
                        HowAgeYou();
                    }
                    else
                    {
                        Console.WriteLine("Введи имя");
                    }
                }
                else if (message == "плохо")
                {
                    Console.WriteLine("Котик не грусти :)");
                }
                else
                {
                    Console.WriteLine("Я тебя не понимаю");
                }
            }
            else if (message == "пока")
            {
                Console.WriteLine("Пока!");
            }
            else
            {
                throw new Exception("Скажите Привет или Пока!");
            }
        }

        static void HowAgeYou()
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


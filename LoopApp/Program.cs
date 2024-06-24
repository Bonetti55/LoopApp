using System;

namespace LoopApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите привет или пока :)");
            string str = Console.ReadLine();

            //Разбить на методы!
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
                        Console.WriteLine($"Приятно познакомиться {str}, Сколько тебе лет?");
                        int age = Convert.ToInt32(Console.ReadLine());
                        if (age < 10)
                        {
                            Console.WriteLine("Иди дневник заполняй!!");
                        }
                        else if (age > 10)
                        {
                            Console.WriteLine("Долгих лет тебе!");
                        }

                        else
                        {
                            Console.WriteLine("Ты что робот?");
                        }
                        
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
                    Console.WriteLine("Я тебя не понимаю!");
                }
            }
            else if(str == "пока")
            {
                Console.WriteLine("пока!");
            }
            else
            {
                throw new Exception("Скажите Привет или Пока!");
            }

            static void Talk()
            {
                
            }

            static void Age()
            {
                
            }
        }
    }
}


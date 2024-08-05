using LoopApp2;

namespace LoopApp
{
    internal static class Program
        
    {
        private static void Main()
        {
            Console.WriteLine("Добро пожаловать в говорилку Bonetti giga chat v1.1, для начала диалога введите 'привет' или 'пока'");
            var message = Console.ReadLine();
            switch (message)
            {
                case "привет":
                    var calculator = new Calculator();
                    calculator.AskHowAreYou();
                    break;
                case "пока":
                    Console.WriteLine("Ня, Пока!");
                    break;
                default:
                    throw new Exception("Скажите Привет или Пока!");
            }
        }
    }
}


namespace LoopApp2;

public class Calculator
{
    public void AskHowAreYou()
    {
        Console.WriteLine("Привет! Как у тебя дела?");
        var message = Console.ReadLine();
        switch (message)
        {
            case "хорошо":
                Console.WriteLine("Как тебя зовут?");
                message = Console.ReadLine();
                Console.WriteLine($"Приятно познакомится {message}!");
                CalculateYears();
                break;
            case "плохо":
                Console.WriteLine("Котик не грусти :)");
                break;
            default:
                Console.WriteLine("Я тебя не понимаю");
                break;
        }
    }

    private void CalculateYears()
    {
        Console.WriteLine("Сколько тебе лет?");
        var age = Convert.ToInt32(Console.ReadLine());
        switch (age)
        {
            case < 10:
                Console.WriteLine("Иди Дневник заполняй!");
                break;
            case > 10:
                Console.WriteLine("Долгих лет тебе товарищ!");
                break;
            default:
                Console.WriteLine("Ты шо робот?");
                break;
        }
    }
}
using SF.HW03.Task12_1_5;
 
class Program
{
    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        Thread.Sleep(3000);
    }

    static void Main(string[] args)
    {
        List<User> users = new List<User>
        {
            new User { Login = "max1", Name = "Максим", IsPremium = true },
            new User { Login = "dandan", Name = "Даниэль", IsPremium = false },
            new User { Login = "petr", Name = "Петр", IsPremium = false }
        };
        foreach (var user in users)
        {
            Console.WriteLine("Привет, {0}", user.Name);
            if (!user.IsPremium)
                ShowAds();
        }
    }
}
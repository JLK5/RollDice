Console.WriteLine("Podaj kość jaką chcesz rzucić:");
Console.WriteLine("1. D3");
Console.WriteLine("2. D4");
Console.WriteLine("3. D6");
Console.WriteLine("4. D20");
Console.WriteLine("q. Wyjście");
Random rng = new Random();
int randomthrow = 0;
string choice = "";
do
{
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            randomthrow = rng.Next(1, 3);
            Console.WriteLine("Wyrzuciłeś: " + randomthrow.ToString());
            break;
        case "2":
            randomthrow = rng.Next(1, 4);
            Console.WriteLine("Wyrzuciłeś: " + randomthrow.ToString());
            break;
        case "3":
            randomthrow = rng.Next(1, 6);
            Console.WriteLine("Wyrzuciłeś: " + randomthrow.ToString());
            break;
        case "4":
            randomthrow = rng.Next(1, 20);
            Console.WriteLine("Wyrzuciłeś: " + randomthrow.ToString());
            break;
        case "q":
            break;
        default:
            Console.WriteLine("Podałeś złą opcje!");
            break;
    }
}
while (choice != "q");

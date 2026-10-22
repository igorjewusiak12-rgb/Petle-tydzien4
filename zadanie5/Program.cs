int zdrowieBohatera = 60;
int zdrowiePrzeciwnika = 45;
int liczbaMikstur = 2;
int numerTury = 1;
bool ucieczka = false;

while (zdrowieBohatera > 0 || zdrowiePrzeciwnika > 0)
{
    Console.WriteLine("+======WALKA======+");
    Console.WriteLine($"Numer tury: {numerTury}");
    Console.WriteLine($"Zdrowie bohatera: {zdrowieBohatera}");
    Console.WriteLine($"Zdrowie przeciwnika: {zdrowiePrzeciwnika}");
    Console.WriteLine("+=================+");
    Console.WriteLine("+======MENU======+");
    Console.WriteLine("1 - Atak");
    Console.WriteLine("2 - Mikstura");
    Console.WriteLine("3 - ucieczka");
    Console.WriteLine("+=================+");
    Console.Write("Wybor akcji: ");
    int akcja = int.Parse(Console.ReadLine());

    switch(akcja)
    {
        case 1:
            zdrowiePrzeciwnika = zdrowiePrzeciwnika - 12;
            zdrowieBohatera = zdrowieBohatera - 7;
            Console.WriteLine("Zadales 12 obrazen przeciwnikowi.");
            Console.WriteLine("W wyniku walki straciles 7 pkt zycia.");
            break;
        
        case 2:
            if (liczbaMikstur>0)
            {
                zdrowieBohatera+=15;
                Console.WriteLine("Uzyles mikstury.Twoj bohater zyskal 15 pkt zycia.")
                Console.WriteLine("-1 mikstura");
                liczbaMikstur-=1;
            }
            else
            {
                Console.WriteLine("Nie posiadasz zadnych mikstur");
            }
            break;
        
        case 3:
            ucieczka = true;
            Console.WriteLine("Uciekles.");
            break;
        
        default:
            Console.WriteLine("Nieznana akcja.");
            continue;
                
    }
    
}

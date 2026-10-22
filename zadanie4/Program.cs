int liczbaTur;
while(true)
{
    Console.Write("Podaj liczbe tur od 1 do 10: ");
    bool poprawnyFormat = int.TryParse(Console.ReadLine(), out liczbaTur);

    if (!poprawnyFormat)
    {
        Console.WriteLine("Podaj liczbe calkowita");
        continue;
    }
    
    
    if (liczbaTur < 1 || liczbaTur > 10)
    {
        Console.WriteLine("Liczba musi nalezec do zakresu 1-10");
        continue;
    }

    break;
}

Console.WriteLine($"Rozpoczynam grę na {liczbaTur} tur. ");

using System.Diagnostics;

Console.Write("Ile dni trwa wyprawa?: ");
int dniWyprawy = int.Parse(Console.ReadLine());

int lacznieZlota = 0;
int zloto = 5;
int mnoznik = 7;
int licznik = 0;

for (int i = 1;i<=dniWyprawy;i++)
{
    Console.Write($"Zloto w dniu {i}: ");
    zloto = i * mnoznik + dniWyprawy;
    if (zloto>=10)
    {
        licznik+=1;
    }
    Console.WriteLine($"{zloto}");
    lacznieZlota = zloto + lacznieZlota;
}

Console.WriteLine($"Lacznie znaleziono: {lacznieZlota} sztuk zlota.");
Console.WriteLine($"Dni z wynikiem powyzej 10: {licznik}");

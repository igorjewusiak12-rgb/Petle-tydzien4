Console.Write("Podaj wysokosc choinki: ");
int wysokosc = int.Parse(Console.ReadLine());

for (int i = wysokosc; wysokosc>0;wysokosc--)
{
    for (int szerokosc = 1; szerokosc>0;szerokosc+=2)
    {
        Console.Write("*");
    }
}

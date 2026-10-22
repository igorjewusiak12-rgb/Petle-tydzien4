///PĘTLA WHILE
/*
int i = 1;
while(i<=10)
{
    Console.WriteLine($"{i}");
    i++;
}
*/



///PĘTLA DO-WHILE
/*
int i = 1;

do
{
    Console.WriteLine($"{i}");
    i++;
}
while(i<=10);
*/

///PĘTLA FOR
/*
for(int i = 1;i<=10;i++)
{
    Console.WriteLine($"{i}");
}
*/


Console.Write("Rosnaco: ");
for (int i=1;i<=10;i++)
{
    Console.Write($"{i} ");
}

Console.Write("\nMalejaco: ");
for (int i=10;i>=1;i--)
{
    Console.Write($"{i} ");
}

Console.Write("\nParzyste: ");
for (int i=0;i<=20;i+=2)
{
    Console.Write($"{i} ");
}
Console.WriteLine("\nStart!");
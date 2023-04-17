int i = 0;
bool alwaysRun=true;

while (alwaysRun)
{
    Random rnd = new Random();
    int xface = rnd.Next(7);
    int yface = rnd.Next(7);
    i++;
    while (xface == 6 && yface == 6 && alwaysRun==true)
    {
        Console.WriteLine(i);
        alwaysRun = false;

    }

}
Console.ReadLine();
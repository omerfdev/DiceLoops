//This program calculates how many tries it takes to get a 6 on both sides of the dice rolled.
int i = 0;
bool alwaysRun=true;

#region 6 - 6 rolls on the dice method.
while (alwaysRun)
{
    Random rnd = new Random();
    int xface = rnd.Next(7);
    int yface = rnd.Next(7);
    i++;
    while (xface == 6 && yface == 6 && alwaysRun==true)
    {
        Console.WriteLine("6-6 Attemps :"+i);
        alwaysRun = false;

    }

}
Console.ReadLine();
#endregion

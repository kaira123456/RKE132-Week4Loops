
Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.Writeline($"cpu has generated {cpuRandom}.");
    Console.WriteLine("Make aguess. Enter a number 1-3");

2    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        //loopactive = false;
        break;
    }
    else
    {
        Console.WriteLine("Oops. try again.");
    }
}

Console.WriteLine("Have a nice day!");

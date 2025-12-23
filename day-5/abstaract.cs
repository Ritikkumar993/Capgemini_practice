abstract class Players{
    protected Players()
    {
        Console.WriteLine("Players");
    }
}

class Play:Players
{
    public Play() : base()
    {
        Console.WriteLine("play game");
    }
}
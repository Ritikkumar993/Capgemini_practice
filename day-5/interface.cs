interface A
{
    static int count=9;
    void print();
    // void scan();
}

class B : A
{
    public void print()
    {
        
        Console.WriteLine("Print count "+A.count);
    }
}
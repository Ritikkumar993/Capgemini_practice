class Lms
{
    private Dictionary<int, string> book = new Dictionary<int, string>();

    public string this[int id]
    {
        get { return book[id];}
        set { book[id]=value; }
    } 

    public string this[string title]
    {
        get
        {
            return book.FirstOrDefault(e=>e.Value==title).Value;
        }
    }

    private string Name;
    public Lms(string name)
    {
        Name=name;
        
    }
    public Lms()
    {
        Console.WriteLine("Parent class");
    }


}

class Ums:Lms
{
    public Ums()
    {
        Console.WriteLine("Child");
    }
}
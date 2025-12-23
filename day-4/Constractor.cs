class Product
{
    public string Name;
    public int Price;

    
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    
    //it is usrd as varible

    public Product() { }

    public Product(string name, int price)
    {
        Price = price;
        Name = name;
    }
}
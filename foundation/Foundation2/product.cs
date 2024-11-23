public class Product
{
    private string name;
    private string productId;
    private double price;

  
    public Product(string name, string productId, double price)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
    }

    
    public double GetPrice()
    {
        return this.price;
    }

   
    public override string ToString()
    {
        return $"{this.name} (ID: {this.productId})";
    }
}


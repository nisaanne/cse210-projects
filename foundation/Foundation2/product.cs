public class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    
    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId; 
        this.price = price;
        
    }

    
    public double GetTotalCost()
    {
        return this.price;
    }

    
    public override string ToString()
    {
        return $"{this.name} (ID: {this.productId})";
    }
}

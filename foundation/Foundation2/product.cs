public class Product
{
    private string name;
    private string productID;
    private double prive;
    private int quantity;


    public Product(string name, string productID, double price, int quantity)
    {
        this.name = name
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;

    }

    public double GetTotalCost()
    {
        return this.price * this.quantity;
    }

    public override string ToString()
    {
        return $"{this.name} (ID: {this.productID})";
    }

}
public class Product
{
    private string _name;
    private string _productId;
    private double _price;

   
    public Product(string name, string productId, double price)
    {
        _name = name;
        _productId = productId;
        _price = price;
    }

   
    public double GetPrice()
    {
        return _price;
    }

    
    public override string ToString()
    {
        return $"{_name} (ID: {_productId})";
    }
}

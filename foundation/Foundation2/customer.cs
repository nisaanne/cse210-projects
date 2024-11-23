public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {this.name = name;
    this.address = address;
    }

    public bool IsInUSA()
    {
        return this. address.IsInUSA();
    }

    public override string ToString()
    {
        return $"{this.name}\n{this.address.ToString()}";
    }
}
public class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;



    public Address(string street, string city, string state, string country)
    {
        this.streetAddress = street;
        this.city = city;
        this.stateProvince = state;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return this.country.ToLower() == "usa";
    }

    public override string ToString()
    {
        return $"{this.streetAddress}\n{this.city}, {this.stateProvince}\n{this.country}";
    }
}
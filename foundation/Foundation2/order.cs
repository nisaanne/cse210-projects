using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products = new List<Product>();
    private Customer customer;

    public Order(Customer customer)
    { 
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        this.products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in this.products)
        {
            totalCost += product.GetTotalCost();
        }
        double shippingCost = this.customer.IsInUSA() ? 5.0 : 35.0;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in this.products)
        {
            label += product.ToString() + "\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{this.customer.ToString()}";
    }
}
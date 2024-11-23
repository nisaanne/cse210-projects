using System;
using System.Collections.Generic;

public class Order
{
    private List<(Product product, int quantity)> products = new List<(Product product, int quantity)>();
    private Customer customer;

  
    public Order(Customer customer)
    { 
        this.customer = customer;
    }

    
    public void AddProduct(Product product, int quantity)
    {
        this.products.Add((product, quantity));
    }

    
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var item in this.products)
        {
            totalCost += item.product.GetPrice() * item.quantity;
        }
        double shippingCost = this.customer.IsInUSA() ? 5.0 : 35.0;
        return totalCost + shippingCost;
    }

    
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var item in this.products)
        {
            label += $"{item.product.ToString()} - Quantity: {item.quantity}\n";
        }
        return label;
    }

    
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{this.customer.ToString()}";
    }
}

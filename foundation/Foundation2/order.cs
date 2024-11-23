using System;
using System.Collections.Generic;

public class Order
{
    private List<(Product product, int quantity)> _products = new List<(Product product, int quantity)>();
    private Customer _customer;

    
    public Order(Customer customer)
    { 
        _customer = customer;
    }

    
    public void AddProduct(Product product, int quantity)
    {
        _products.Add((product, quantity));
    }

  
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var item in _products)
        {
            totalCost += item.product.GetPrice() * item.quantity;
        }
        double shippingCost = _customer.IsInUSA() ? 5.0 : 35.0;
        return totalCost + shippingCost;
    }

    
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var item in _products)
        {
            label += $"{item.product.ToString()} - Quantity: {item.quantity}\n";
        }
        label += $"Total Cost: ${GetTotalCost():0.00}\n";
        return label;
    }

    
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.ToString()}";
    }
}



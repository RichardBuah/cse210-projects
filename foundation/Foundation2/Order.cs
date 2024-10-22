using System;
using System.Runtime.CompilerServices;

public class Order
{
    private Customer _customer;
    private List<Product> _productList;
    public Order(Customer customer, List<Product> product)
    {
        _customer = customer;
        _productList = product;
    }
    public double GetTotalCost(double dileveryCost)
    {
        double totalCost = 0;
        
        foreach(Product item in _productList)
        {
            totalCost += item.GetTotalCost();
        }
        totalCost += dileveryCost;
        return totalCost;
    }
    public string GetPackingLabel(string customer, int number)
    {
        return $"{customer}-{_productList[number].GetProductName()}{_productList[number].GetProductId()}";
    }
    public string GetShippingLabel(string customer, string address)
    {
        return $"{customer}--{address}";
    }
}
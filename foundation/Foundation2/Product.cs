using System;
using System.Security.Cryptography;

public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productId = productID;
        _price = price;
        _quantity = quantity;
    }
    public string GetProductName()
    {
        return $"{_name}";
    }
    public string GetProductId()
    {
        return $"{_productId}";
    }
    public double GetTotalCost()
    {
        double totalCost = _price * _quantity;
        return totalCost;
    }
}
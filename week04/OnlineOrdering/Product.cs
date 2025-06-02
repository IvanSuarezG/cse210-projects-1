using System;
using System.IO;

public class Product
{
    private string _name;
    private int _IDproduct;
    private int _quantity;
    private double _price;

    public Product(string name, int IDproduct, int quantity, double price)
    {
        _name = name;
        _IDproduct = IDproduct;
        _quantity = quantity;
        _price = price;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetIDproduct()
    {
        return _IDproduct;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double GetPrice()
    {
        return _price;
    }
    public double TotalCostProduct()
    {
        return _quantity * _price;
    }
}
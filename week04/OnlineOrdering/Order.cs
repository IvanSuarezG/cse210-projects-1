using System;
using System.IO;

public class Order
{
    private List<Product> _products;
    private List<Customer> _customer;
   
    


    public Order(List<Product> products, List<Customer> customer)
    {
        _products = products;
        _customer = customer;
    }
    public double TotalCostOrder()
    {
        double TotalCost = 0;
        double shippingCost;

        foreach (Customer customer in _customer)
        {
            if (customer.IsInUsa())
            {
                shippingCost = 5.00;  // Shipping cost for USA
            }
            else
            {
                shippingCost = 35.00; // Shipping cost for non-USA
            }

            foreach (Product product in _products)
            {

                TotalCost += product.TotalCostProduct();
            }
            TotalCost += shippingCost; // Add shipping cost to total
        }
        return TotalCost;
    }

    public string PackingLabel()
    {
        string label = "";
        foreach (Customer customer in _customer)
        {
            label += $"Customer: {customer.GetName()}\n";
        }

        foreach (Product product in _products)
        {
            label += $"Product ID: {product.GetIDproduct()} \n";
        }

        return label;
    }

    public string ShippingLabel()
    {
        string label = "";

        foreach (Customer customer in _customer)
        {
            label += $"Customer: {customer.GetName()} \n" +
                     $"Address: {customer.GetCompleteAddress().GetFullAddress()} \n";
        }
        return label;
    }

}


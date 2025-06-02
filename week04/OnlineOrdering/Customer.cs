using System;
using System.IO;


public class Customer
{
    private string _name;
    private Address _CompleteAddress;


    public Customer(string name, Address completeAddress)
    {
        _name = name;
        _CompleteAddress = completeAddress;
    }
    
    public string GetName()
    {
        return _name;
    }

    public Address GetCompleteAddress()
    {
        return _CompleteAddress;
    }

    public bool IsInUsa()
    {
        if (_CompleteAddress.GetCountry().ToLower() == "usa")
        {
            return true;
        }

        return false;
    }
}
using System;
using System.IO;

public class Address
{
    private string _city;
    private string _state;
    private string _country;


    public Address(string city, string state, string country)
    {
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetCity()
    {
        return _city;
    }
    public string GetState()
    {
        return _state;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetFullAddress()
    {
        return $"{_city} / {_state} / {_country}";
    }
}
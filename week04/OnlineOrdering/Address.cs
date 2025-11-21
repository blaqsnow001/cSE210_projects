using System;
using System.Collections.Generic;

// Address class - stores address information
class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // Constructor
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // Check if address is in USA
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES";
    }

    // Return full address as a formatted string
    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }

    // Getters
    public string GetStreetAddress() { return _streetAddress; }
    public string GetCity() { return _city; }
    public string GetState() { return _state; }
    public string GetCountry() { return _country; }
}
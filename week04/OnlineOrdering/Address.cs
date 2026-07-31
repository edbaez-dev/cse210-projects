using System;

public class Address
{
    private string _street;
    private string _cityState;
    private string _country;

    public Address(string street, string cityState, string country)
    {
        _street = street;
        _cityState = cityState;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_cityState}\n{_country}";
    }
}
class Address
{
    private string _streetAdd = "";
    private string _city = "";
    private string _stateProv = "";
    private string _country = "";
    public Address(string street, string city, string stateProv, string country)
    {
        _streetAdd = street;
        _city = city;
        _stateProv = stateProv;
        _country = country;
    }
    public string GetStreet()
    {
        return _streetAdd;
    }
    public void SetStreet(string add)
    {
        _streetAdd = add;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetStateProv()
    {
        return _stateProv;
    }
    public void SetStateProv(string stateProv)
    {
        _stateProv = stateProv;
    }
    public string GetCountry() // the getter already does the function of telling me its in the US or not
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public string GetFullAddress()
    {
        return $"{GetStreet()}\n{GetCity()}, {GetStateProv()}\n{GetCountry()}\n";
    }
}
class Address
{
    private string _streetAdd = "";
    private string _city = "";
    private string _stateProv = "";
    private string _country = "";
    public Address()
    {

    }
    public string getAdd()
    {
        return _streetAdd;
    }
    public void setAdd(string add)
    {
        _streetAdd = add;
    }
    public string getCity()
    {
        return _city;
    }
    public void setCity(string city)
    {
        _city = city;
    }
    public string getStateProv()
    {
        return _stateProv;
    }
    public void setStateProv(string stateProv)
    {
        _stateProv = stateProv;
    }
    public string getCountry() // the getter already does the function of telling me its in the US or not
    {
        return _country;
    }
    public void setCountry(string country)
    {
        _country = country;
    }
    public void display()
    {
        System.Console.WriteLine($"{_streetAdd}\n{_city}, {_stateProv}\n{_country}");
    }
}
class Customer
{
    private string _name = "";
    private Address _address = new Address();
    public Customer()
    {
        
    }
    public string getName()
    {
        return _name;
    }
    public void setName(string name)
    {
        _name = name;
    }
    public int shippingLocation(string country)
    {
        country = _address.getCountry();
        int shippingCost = 5;
        if (country != "United States")
        {
            shippingCost = 35;
        }
        return shippingCost;
    }
    public void getAddress()
    {
        System.Console.WriteLine(_address.getFullAddress());
    }
    public string getCountry()
    {
        return _address.getCountry();
    }
    public void setAdd(string address, string city, string stateProv, string country)
    {
        _address.setAdd(address);
        _address.setCity(city);
        _address.setStateProv(stateProv);
        _address.setCountry(country);
    }
}
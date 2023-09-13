class Customer
{
    private string _name = "";
    private Address address = new Address();
    public Customer()
    {
        
    }
    
    public int shippingLocation(string country)
    {
        country = address.getCountry();
        System.Console.Write("Where do you want this shipped to?: ");
        int shippingCost = 5;
        if (country != "United States")
        {
            shippingCost = 35;
        }
        return shippingCost;
    }
    public void getAddress()
    {
        address.display();
    }
}
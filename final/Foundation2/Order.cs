class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();
    private double _totalPrice = 0;
    public Order()
    {
        System.Console.Write("Who is Making this order?: ");
        _customer.setName(Console.ReadLine());
        System.Console.Write("Where will this be shppied to? Please Enter your address in this format:\n");
        System.Console.WriteLine($"Street Address\nCity\nState or Province\nCountry\nEnter each one individually pressing enter after each one:");
        _customer.setAdd(Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine());
    }
    public void addProduct() //adds product to list of products and add price to total price
    {
        Product p = new Product();
        
        System.Console.Write("What is the product name?: ");
        p.setName(Console.ReadLine());

        System.Console.Write("What is the product ID?: ");
        p.setID(int.Parse(Console.ReadLine()));

        System.Console.Write("What is the price of the product?: ");
        double price = Double.Parse(Console.ReadLine());

        System.Console.Write("How many are you ordering?: ");
        int quantity = int.Parse(Console.ReadLine());
        p.setPrice(price, quantity);
        _products.Add(p);

        _totalPrice = _totalPrice + p.getPrice();
    }
    public double calculateOrder() //calculates total cost
    {
        string country = _customer.getCountry();
        double shippingPrice = _customer.shippingLocation(country) + _totalPrice;
        return shippingPrice;
    }
    public string packingLabel() //returns a string will all product names and ID's
    {
        int itemCount = 1;
        string label = "";
        foreach(Product p in _products)
        {
            label += $"{p.getName()}: {p.getPrice()}, {p.getID()}\n";
            itemCount ++;
        }
        return label;
    }
    public void shippingLabel()
    {
        System.Console.WriteLine(_customer.getName());
        _customer.getAddress();
    }
}
class Order
{
    private string _shippingLabel = "";
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();
    private double _totalPrice = 0;
    public Order()
    {

    }
    public void addProduct() //adds product to list of products and add price to total price
    {
        Product p = new Product();
        
        System.Console.Write("What is the prodct name?: ");
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
        string country = "";
        double shippingPrice = _customer.shippingLocation(country) + _totalPrice;
        return _totalPrice;
    }
    public string packingLabel() //returns a string will all product names and ID's
    {
        int itemCount = 1;
        string label = "";
        foreach(Product p in _products)
        {
            label += $"Item {itemCount}: {p.getPrice()}, {p.getID()}\n";
        }
        return label;
    }
    public string shippingLabel()
    {
        string label = "";
        label += _customer.
    }
}
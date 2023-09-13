class Product
{
    private string _name = "";
    private int _ID = 0;
    private double _price = 0;
    
    public string getName()
    {
        return _name;
    }
    public void setName(string name)
    {
        _name = name;
    }
    public int getID()
    {
        return _ID;
    }
    public void setID(int ID)
    {
        _ID= ID;
    }
    public double getPrice()
    {
        return _price;
    }
    public void setPrice(double price, int quantity)
    {
        price = price*quantity;
        _price = price;
    }
}
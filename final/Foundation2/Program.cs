using System;

class Program
{
    static void Main(string[] args)
    {
        Order _order1 = new Order();
        for (int i = 0; i<3; i++)
        {
            _order1.addProduct();
        }

        Order _order2 = new Order();
        for (int i = 0; i<3; i++)
        {
            _order2.addProduct();
        }
        System.Console.WriteLine("Order 1 Packing Label:");
        System.Console.WriteLine(_order1.packingLabel());
        System.Console.WriteLine(_order1.calculateOrder());
        _order1.shippingLabel();
        System.Console.WriteLine("Order 2 Packing Label:");
        System.Console.WriteLine(_order2.packingLabel());
        System.Console.WriteLine($"This will cost you ${_order2.calculateOrder()}");
        _order2.shippingLabel();

    }
}
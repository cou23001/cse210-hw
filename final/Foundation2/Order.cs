public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order (Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public double GetTotalCostOrder()
    {
        double total = 0;
        foreach (Product product in _products) {
            total = total + product.GetPriceProduct();
        }
        double value = total + GetShippingCost(_customer);
        return Math.Round(value,2);
    }

    public double GetShippingCost(Customer customer)
    {
        if (customer.IsUSAResident())
        {
            return 5;
        }
        else{
            return 35;
        }
    }

    public string GetPackingLabel()
    {
        string data = "\nPacking Label\n- ID - | Qty | Price | --- Product Name ---\n";
        foreach (Product p in _products)
        {
            data = data + $"{p.GetProductID()}     {p.GetQty()}      {p.GetPrice()}      {p.GetName()}\n";
        }
        return ($"{data}");
    }

    public string GetShippingLabel() 
    {
        return ($"{_customer.GetName()}\n{_customer.GetAddress()}");
    }
}
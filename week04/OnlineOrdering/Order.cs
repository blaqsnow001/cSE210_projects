class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculate total cost including shipping
    public double CalculateTotal()
    {
        double total = 0;

        // Add up all product costs
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost
        if (_customer.LivesInUSA())
        {
            total += 5.00;  // USA shipping
        }
        else
        {
            total += 35.00;  // International shipping
        }

        return total;
    }

    // Generate packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductId()}\n";
        }
        return label;
    }

    // Generate shipping label
    public string GetShippingLabel()
    {
        string label = "Shipping Label:\n";
        label += $"{_customer.GetName()}\n";
        label += _customer.GetAddress().GetFullAddress();
        return label;
    }
}
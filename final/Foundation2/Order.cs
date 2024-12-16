public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    // Calculate total cost including product costs and shipping
    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.CalculateTotalCost();
        }
        
        // Add shipping based on whether the customer is in the USA
        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    // Returns a packing label with product name and product ID
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (Product ID: {product.GetProductID()})\n";
        }
        return label;
    }

    // Returns a shipping label with customer's name and address
    public string GetShippingLabel()
    {
        string label = $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}\n";
        return label;
    }
}

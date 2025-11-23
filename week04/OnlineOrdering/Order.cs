using System.Collections.Generic;
  
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL:\n";
        foreach (Product p in _products)
        {
            label += $"{p.GetName()} (ID: {p.GetId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{_customer.GetName()}\n{_customer.GetAddressString()}";
    }

    public double GetTotalCost()
    {
        double productTotal = 0;
        foreach (Product p in _products)
        {
            productTotal += p.TotalCost();
        }

        double shipping = _customer.LivesInUSA() ? 5 : 35;

        return productTotal + shipping;
    }
}

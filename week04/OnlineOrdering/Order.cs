using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public List<Product> GetProducts() => _products;
    public void SetProducts(List<Product> products) => _products = products;

    public void AddProduct(Product product) => _products.Add(product);

    public decimal CalculateTotal()
    {
        decimal shippingCost = _customer.LivesInUSA() ? 5m : 35m;
        decimal totalProductCost = 0;

        foreach (var product in _products)
        {
            totalProductCost += product.TotalCost();
        }

        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        var label = new System.Text.StringBuilder();
        foreach (var product in _products)
        {
            label.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
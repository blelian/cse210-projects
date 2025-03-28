public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName() => _name;
    public void SetName(string name) => _name = name;

    public string GetProductId() => _productId;
    public void SetProductId(string productId) => _productId = productId;

    public decimal GetPrice() => _price;
    public void SetPrice(decimal price) => _price = price;

    public int GetQuantity() => _quantity;
    public void SetQuantity(int quantity) => _quantity = quantity;

    public decimal TotalCost() => _price * _quantity;
}
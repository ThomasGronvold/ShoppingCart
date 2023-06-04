namespace ShoppingCart;

public class Product
{
    private string _name;
    private int _price;

    public Product(string name, int price)
    {
        _name = name;
        _price = price;
    }
    public bool CheckIfProductExist(string productName)
    {
        return _name == productName;
    }

    public void WriteProducts()
    {
        Console.WriteLine($"Product Name: {_name} - Product Price: {_price}");
    }

    public void WritePrice()
    {
        Console.Write($"{_price}.");
    }

    public int IncreaseTotalPrice(int quantity)
    {
        return (_price * quantity);
    }
}
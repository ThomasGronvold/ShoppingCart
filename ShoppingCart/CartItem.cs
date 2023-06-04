using System.Diagnostics;
using System.Xml.Linq;

namespace ShoppingCart;

public class CartItem
{
    private string _name;
    private int _quantity;

    public CartItem(string name, int quantity)
    {
        _name = name;
        _quantity = quantity;
    }
    public void IncreaseQuantity(int quantityToAdd)
    {
        _quantity += quantityToAdd;
    }

    public bool checkIfItemExist(string productName)
    {
        return _name == productName;
    }

    public void WriteItems(List<Product> _allProducts)
    {
        var product = _allProducts.FirstOrDefault(product => product.CheckIfProductExist(_name));
        Console.Write($"Item Name: {_name} - Item Quantity: {_quantity} - Item Price: ");
        product.WritePrice();
        Console.WriteLine();
    }
}
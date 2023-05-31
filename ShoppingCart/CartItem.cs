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
    public string GetCartProductName()
    {
        return _name;
    }
    public int GetCartProductQuantity()
    {
        return _quantity;
    }

    public void IncreaseQuantity(int quantityToAdd)
    {
        _quantity += quantityToAdd;
    }
}

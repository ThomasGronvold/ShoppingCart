using System.Runtime.Intrinsics.X86;

namespace ShoppingCart;

public class ShoppingCart
{
    private List<CartItem> _cart;
    private List<Product> _allProducts;
    private int _totalPrice;

    public ShoppingCart()
    {
        _cart = new List<CartItem>();
        _allProducts = new List<Product>();
    }

    public void AddToCart(string productName, int quantity)
    {
        var cartItem = SearchCartItemsForProductName(productName);
        var product = DoesProductExist(productName);

        if (product != null)
        {
            if (cartItem != null)
            {
                cartItem.IncreaseQuantity(quantity);
                _totalPrice += product.IncreaseTotalPrice(quantity);
            }
            else
            {
                _cart.Add(new CartItem(productName, quantity));
                _totalPrice += product.IncreaseTotalPrice(quantity);
            }
        }
    }

    public void AddProductToList(string productName, int price)
    {
        var doesProductExist = DoesProductExist(productName);

        if (doesProductExist == null)
        {
            _allProducts.Add(new Product(productName, price));
        }
    }

    private Product? DoesProductExist(string productName)
    {
        /* Checks if the parameter form the User (string productName) is an actual product in the "_allProducts" list.
        If it is not an actial product the method will return null. */
        return _allProducts.FirstOrDefault(product => product.CheckIfProductExist(productName));
    }

    private CartItem? SearchCartItemsForProductName(string productName)
    {
        /* Finds out if the product the user wants to add (string productName) is already an item inside the "_cart" list.
        If it is not a match the method will return null. */
        return _cart.FirstOrDefault(item => item.checkIfItemExist(productName));
    }

    public void ShowCart()
    {
        if (_cart.Count == 0)
        {
            Console.WriteLine("Your shopping cart is empty.");
        }
        else
        {
            foreach (var cartItem in _cart)
            {
                cartItem.WriteItems(_allProducts);
            }
            Console.WriteLine($"Total price for all items in cart is: {_totalPrice}.");
        }
    }

    public void ShowProducts()
    {
        foreach (var product in _allProducts)
        {
            product.WriteProducts();
        }
    }
}
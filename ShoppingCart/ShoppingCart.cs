namespace ShoppingCart;

public class ShoppingCart
{
    private List<CartItem> _cart;
    private int totalPrice;
    public ShoppingCart()
    {
        _cart = new List<CartItem>();
    }
    public void AddToCart(CartItem product)
    {
        bool itemExcistsInArray = false;
        foreach (var cartProduct in _cart)
        {
            if (cartProduct.GetCartProductName() == product.GetCartProductName())
            {
                cartProduct.IncreaseQuantity(product.GetCartProductQuantity());
                itemExcistsInArray = true;
                break;
            }
        }
        if (!itemExcistsInArray)
        {
            _cart.Add(product);
        }
    }
    public int FindProductPrice(string productName, ProductArray productArray)
    {
        /* Returns the ProductArray through a method because it's set to Private */
        var array = productArray.GetProductArray();
        /* Finds the first product with the same name as the name parameter */
        var productToReturn = array.First(product => product.GetProductName() == productName);
        return productToReturn.GetProductPrice();
    }
    public void ShowCart(ProductArray productArray)
    {
        foreach (var item in _cart)
        {
            string productName = item.GetCartProductName();
            int productQuantity = item.GetCartProductQuantity();
            int productPrice = FindProductPrice(productName, productArray);

            Console.WriteLine($"Product Name: {productName} " +
                              $"- Product Quantity: {productQuantity} " +
                              $"- Product Price: {productPrice}.");
            totalPrice += productPrice * productQuantity;

        }
        Console.WriteLine($"Total Price: {totalPrice}");
    }
}
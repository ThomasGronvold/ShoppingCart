using System.Linq;

namespace ShoppingCart;

public class ProductArray
{
    private Product[] _products;
    public ProductArray(int size)
    {
        _products = new Product[size];
    }
    public void AddProductToArray(string name, int price)
    {
        /* if the array does not contain null, it means it's full, and to add a new product we need to increase the size */
        if (!_products.Contains(null))
        {
            int newArraySize = _products.Length * 2;
            var newArray = new Product[newArraySize];
            Array.Copy(_products, newArray, _products.Length);
            _products = newArray;
        }
        /* Finds a null in the array then puts in the new product class there, then breaks to stop the loop  */
        foreach (var product in _products)
        {
            if (product == null)
            {
                int index = Array.IndexOf(_products, product);
                _products[index] = new Product(name, price);
                break;
            }
        }
    }
    public CartItem GetProduct(string productName, int quantity)
    {
        /* Looks for the first product with the same name as the parameter product name, and returns that product */
        var productToReturn = _products.First(product => product.GetProductName() == productName);
        /* Creates a new "CartItem" which holds the product's name and quantity */
        var addAsCartItem = new CartItem(productToReturn.GetProductName(), quantity);
        return addAsCartItem;
    }
    public void PrintAllProducts()
    {
        /* Using a Break to have a more efficient code. */
        foreach (var product in _products)
        {
            if (product != null)
            {
                Console.WriteLine($"Product's Name: {product.GetProductName()} - Price: {product.GetProductPrice()}");
            }
            else
            {
                break;
            }
        }
    }
    public Product[] GetProductArray()
    {
        return _products;
    }
}
namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productArray = new ProductArray(3);
            productArray.AddProductToArray("Salmon", 200);
            productArray.AddProductToArray("Bacon", 40);
            productArray.AddProductToArray("Corn", 30);
            
            //productArray.PrintAllProducts();

            var shoppingCart = new ShoppingCart();
            shoppingCart.AddToCart(productArray.GetProduct("Salmon", 2));
            shoppingCart.AddToCart(productArray.GetProduct("Bacon", 2));
            shoppingCart.AddToCart(productArray.GetProduct("Corn", 9));

            shoppingCart.ShowCart(productArray);
        }
    }
}
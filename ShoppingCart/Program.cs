namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shoppingCart = new ShoppingCart();

            shoppingCart.AddProductToList("Salmon", 200);
            shoppingCart.AddProductToList("Bacon", 40);
            shoppingCart.AddProductToList("Corn", 30);

            shoppingCart.ShowProducts(); /* Uncomment to see all the products and their cost */

            shoppingCart.AddToCart("Salmon", 3);
            //shoppingCart.AddToCart("Salmon", 3);
            //shoppingCart.AddToCart("Salmon", 3);
            shoppingCart.AddToCart("Bacon", 2);
            shoppingCart.AddToCart("Corn", 9);

            shoppingCart.ShowCart();
        }
    }
}
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

            /* Uncomment to test that adding more items works and will update the "dynamic" array */
            //productArray.AddProductToArray("Sirup", 37);
            //productArray.AddProductToArray("Flower", 120);
            //productArray.AddProductToArray("Newspaper", 70);

            //productArray.PrintAllProducts(); /* Uncomment to see all the products and their cost */

            var shoppingCart = new ShoppingCart();
            shoppingCart.AddToCart(productArray.GetProduct("Salmon", 2));
            shoppingCart.AddToCart(productArray.GetProduct("Bacon", 2));
            shoppingCart.AddToCart(productArray.GetProduct("Corn", 9));

            /* Uncomment to test adding multiple of the same product into the cart, and watch the quantity go up */
            //shoppingCart.AddToCart(productArray.GetProduct("Corn", 9));
            //shoppingCart.AddToCart(productArray.GetProduct("Corn", 9));
            //shoppingCart.AddToCart(productArray.GetProduct("Corn", 9));

            shoppingCart.ShowCart(productArray);
        }
    }
}
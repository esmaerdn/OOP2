namespace Encapsulation_v2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 100;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Armut";
            product2.Price = 200;
            product2.Description = "Yeşil armut";            



            Product[] products = new Product[] {product1,product2};
            foreach (Product product in products) 
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("-----------");
            }
            //encapsulation
            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product1);

            //cartManager.Add2("Karpuz", "Kelek karpuz", 50, 100);



        }
    }
}

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.name = "Apple";
            product1.description = "Amasya";
            product1.price = 15;
            product1.stockQuantity = 2;

            Product product2 = new Product();
            product2.name = "Banana";
            product2.description = "Antalya";
            product2.price = 25;
            product1.stockQuantity = 1;

            Product[] products = new Product[] { product1, product2 };

            Console.WriteLine("Ürün Listesi : ");
            foreach (var product in products)
            {
                Console.WriteLine("Product Name : " + product.name + " - " 
                    + "Product Description : " + product.description + " - " 
                    + "Product Price : " + product.price);
            }

            Console.WriteLine("***********Functions***********");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Add(product1);
            sepetManager.Add(product2);
        }
    }
}


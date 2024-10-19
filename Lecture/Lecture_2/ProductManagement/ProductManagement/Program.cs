using ProductManagement.Business;

List <Product> products = new ()
{
    new Electronics("Smartphone", 1000, "Electronics"),
    new Food("Apple", 1, "Food"),
    new Clothing("T-Shirt", 10, "Clothing"),
    new Electronics("Tablet", 500, "Electronics")
};

foreach (var product in products)
{
    product.Discount(10);
    Console.WriteLine(product.GetDetails());
}
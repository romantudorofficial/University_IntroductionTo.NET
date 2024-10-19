namespace ProductManagement.Business
{
    public abstract class Product
    {
        public Product (string name, decimal price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public string Name { get; }
        public decimal Price { get; private set; }
        public string Category { get; }

        public virtual string GetDetails ()
        {
            return $"Name: {Name}, Price: {Price}, Category: {Category}";
        }

        public void Discount (decimal percentage)
        {
            Price = Price - (Price * percentage / 100);
        }
    }
}
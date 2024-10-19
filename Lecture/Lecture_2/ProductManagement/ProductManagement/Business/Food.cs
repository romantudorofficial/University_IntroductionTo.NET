namespace ProductManagement.Business
{
    public class Food : Product
    {
        public Food (string name, decimal price, string category) : base (name, price, category)
        {
        }

        public override string GetDetails ()
        {
            return $"Custom Details!{Price}";
        }
    }
}
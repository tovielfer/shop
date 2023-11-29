namespace shop.Entities
{

    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Provider CurrentProvider { get; set; }
        public int Sum { get; set; }
        public Dictionary<Product,int> products { get; set; }

    }
}

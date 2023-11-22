namespace shop.Entities
{
    public enum Position
    {
        managar,cashier,salesman
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public Position Position { get; set; }

    }
}

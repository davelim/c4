namespace Helpers
{
    public class MenuItem
    {
        // field(s)
        // accessor(s)
        public double Price {get; set;}
        public string Description {get; set;}
        public string Category {get; set;}
        public bool IsNew {get; set;} = true;
        // constructor(s)
        public MenuItem(double price, string description, string category) {
            Price = price;
            Description = description;
            Category = category;
        }
        // instance method(s)
    }
}
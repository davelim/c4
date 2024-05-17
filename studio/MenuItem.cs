namespace Helpers
{
    public class MenuItem
    {
        // field(s)/propert(y/ies)
        // TODO: unique IDs for menu items (to simplify remove)
        // public static int nextIdNum = 0;
        // public readonly int menuId; // set at constructor
        // private const TimeSpan stale = new TimeSpan(365, 6, 0, 0);

        // TODO: use "date added" to determine if an item "is new"
        //public readonly DateTime DateAdded; // set at constructor
        public double Price {get; set;}
        public string Description {get; set;}
        public string Category {get; set;}
        // TODO: when does IsNew get set to false?
        public bool IsNew {get; set;} = true;
        // public bool IsNew
        // {
        //     get {}
        //     set{}
        // } = true;
        // constructor(s)
        public MenuItem(double price, string description, string category) {
            Price = price;
            Description = description;
            Category = category;
            // DateAdded = DateTime.Now;
            // menuId = getNextIdNum();
        }
        // overridden method(s)
        // TODO: override GetHashCode()
        public override bool Equals(object? obj)
        {
            // TODO: compare with "Visual Studio Generation Shortcut"
            if (obj == this) {return true;}
            if (obj == null) {return false;}
            if (obj.GetType() != this.GetType()) {return false;}
            MenuItem? mi = obj as MenuItem;
            return mi.Description == Description;
        }
        public override string ToString()
        {
            return $"{Environment.NewLine}{Description} ({Category}), ${Price}";
        }
        // instance method(s)
        // private int getNextIdNum(){
        //     return nextIdNum++;
        // }
    }
}
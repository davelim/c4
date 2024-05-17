namespace Helpers
{
    public class MenuItem
    {
        // field(s)/propert(y/ies)
        // TODO: unique IDs for menu items (for faster remove)
        // public static int nextIdNum = 0;
        // public readonly int menuId; // set at constructor

        private static int monthsToOld = 6;
        private readonly DateTime DateOld; // set at constructor
        public double Price {get; set;}
        public string Description {get; set;}
        public string Category {get; set;}
        public bool IsNew => System.DateTime.Compare(System.DateTime.Now, DateOld) < 0;
        // constructor(s)
        public MenuItem(double price, string description, string category, bool testTime=false) {
            Price = price;
            Description = description;
            Category = category;
            DateOld = DateTime.Now.AddMonths(monthsToOld);
            // TODO: for testing, is there a better way?
            if (testTime) {DateOld = DateTime.Now.AddSeconds(1);}
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
            return $"{Description} ({Category}), ${Price}";
        }
        // instance method(s)
        // private int getNextIdNum(){
        //     return nextIdNum++;
        // }
    }
}
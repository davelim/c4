namespace Helpers
{
    public class Menu
    {
        // field(s)/proper(y/ies)
        // TODO: make _menuItems dictionary for quicker remove
        private List<MenuItem> _menuItems = [];
        public DateTime? LastUpdated {
             get {return _lastUpdated;}
        }
        private DateTime? _lastUpdated; // set at constructor
        // constructor(s)
        public Menu() {
            _lastUpdated = DateTime.Now;
        }
        // overridden method(s)
        public override string ToString()
        {
            string nl = Environment.NewLine;
            System.Text.StringBuilder menuSB = new();
            foreach (MenuItem mi in _menuItems) {
                menuSB.Append(mi);
            }
            // implicit conversion to string
            return nl + "WELCOME TO OUR RESTAURANT"
                   + nl + Constants.DASHED_LINE
                   + menuSB + nl;
        }
        // instance method(s)
        public void AddMenuItem(MenuItem menuItem) {
            foreach (MenuItem mi in _menuItems) {
                if (menuItem.Equals(mi)) {
                    Console.WriteLine($"Warning: menu already has {menuItem}");
                    return;
                }
            }
            _menuItems.Add(menuItem);
            _lastUpdated = DateTime.Now;
        }
        public void RemoveMenuItem(string description) {
            MenuItem? removeItem = null;
            foreach (MenuItem mi in _menuItems) {
                if (description.Equals(mi.Description)) {
                    removeItem = mi;
                    break;
                }
            }
            if (removeItem != null) {
                _menuItems.Remove(removeItem);
                _lastUpdated = DateTime.Now;
            }
        }
        public void RemoveMenuItem(MenuItem menuItem) {
            string removeDesc = menuItem.Description;
            RemoveMenuItem(removeDesc);
        }
    } // class
} // namespace
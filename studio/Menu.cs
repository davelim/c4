namespace Helpers
{
    public class Menu
    {
        // field(s)/proper(y/ies)
        // TODO: make _menuItems dictionary for quicker remove
        // TODO: what is PropertyChangedEventHandler? Use to connect menuItems to lastupdated?
        private List<MenuItem> _menuItems = [];
        public DateTime? LastUpdated {get; private set;} // set at constructor
        // constructor(s)
        public Menu() {
            LastUpdated = DateTime.Now;
        }
        // overridden method(s)
        public override string ToString()
        {
            string nl = System.Environment.NewLine;
            System.Text.StringBuilder menuSB = new();
            foreach (MenuItem mi in _menuItems) {
                menuSB.Append(nl);
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
                    Console.WriteLine($"Warning: menu already has '{menuItem}'");
                    return;
                }
            }
            _menuItems.Add(menuItem);
            LastUpdated = DateTime.Now;
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
                LastUpdated = DateTime.Now;
            }
        }
        public void RemoveMenuItem(MenuItem menuItem) {
            string removeDesc = menuItem.Description;
            RemoveMenuItem(removeDesc);
        }
    } // class
} // namespace
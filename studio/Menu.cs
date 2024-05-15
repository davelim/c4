namespace Helpers
{
    public class Menu
    {
        // field(s)
        private List<MenuItem> _menuItems = [];
        private DateTime _lastUpdated = DateTime.Now;
        public DateTime LastUpdated {
             get {return _lastUpdated;}
        }
        // accessor(s)
        public DateTime LastUpdate {get;}
        // constructor(s)
        // instance method(s)
        public void AddMenuItem(MenuItem menuItem) {
            _menuItems.Add(menuItem);
            _lastUpdated = DateTime.Now;
        }
    }
}
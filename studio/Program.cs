using Helpers;

// Console.WriteLine("Hello, World!");
MenuItem item1 = new MenuItem(10.50, "Yummy item", "appetizer");
Console.WriteLine($"> item to string... {item1}"); // implicit conversion
MenuItem item2 = new MenuItem(5.0, "Yummy item 2", "main course");

Menu menu = new ();
menu.AddMenuItem(item1);
menu.AddMenuItem(item2);
Console.WriteLine($"> after add 2 items... menu.LastUpdate: {menu.LastUpdated}");
System.Threading.Thread.Sleep(2000);
menu.AddMenuItem(new (8.0, "Yummy item 3", "dessert"));
Console.WriteLine($"> after sleep and add... menu.LastUpdate: {menu.LastUpdated}");

// no add, warning
Console.WriteLine("> try to add already existing item...");
menu.AddMenuItem(new (10.50, "Yummy item", "appetizer"));

Console.WriteLine($"> after adds... menu: {menu}");
menu.RemoveMenuItem("Yummy item 3");
Console.WriteLine($"> after remove (item 3)... menu: {menu}");

// IsNew computed property
MenuItem item = new MenuItem(1, "test", "app", true);
Console.WriteLine($"> new test... item.IsNew: {item.IsNew}");
System.Threading.Thread.Sleep(2000);
Console.WriteLine($"> two seconds after test item.IsNew: {item.IsNew}");
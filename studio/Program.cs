using Helpers;

// Console.WriteLine("Hello, World!");
MenuItem item1 = new MenuItem(10.50, "Yummy item", "appetizer");
Console.WriteLine($"item to string... {item1}"); // implicit conversion
MenuItem item2 = new MenuItem(5.0, "Yummy item 2", "main course");

Menu menu = new ();
menu.AddMenuItem(item1);
menu.AddMenuItem(item2);
Console.WriteLine($"> after add 2 items... {menu.LastUpdated}");
System.Threading.Thread.Sleep(2000);
menu.AddMenuItem(new (8.0, "Yummy item 3", "dessert"));
Console.WriteLine($"> after sleep and add... {menu.LastUpdated}");
// no add, warning
menu.AddMenuItem(new (10.50, "Yummy item", "appetizer"));

Console.WriteLine($"> After adds... {menu}");
menu.RemoveMenuItem("Yummy item 3");
Console.WriteLine($"> After remove (item 3)... {menu}");
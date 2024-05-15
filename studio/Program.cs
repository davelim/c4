using Helpers;

// Console.WriteLine("Hello, World!");
MenuItem item1 = new MenuItem(10.50, "Yummy dish", "appetizer");
Console.WriteLine(item1.IsNew);
Menu menu = new ();
Console.WriteLine(menu.LastUpdated);
Thread.Sleep(2000);
menu.AddMenuItem(item1);
Console.WriteLine(menu.LastUpdated);
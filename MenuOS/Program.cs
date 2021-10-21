using System;

namespace MenuOS
{
    class ItemA:IMenuItem
    {
        public string MenuItemName() { return "ItemA"; }
        public void Run()
        {
            Console.WriteLine("Item A is running now!");
            Console.ReadKey();
        }
    }

    class ItemB : IMenuItem
    {
        public string MenuItemName() { return "ItemB"; }
        public void Run()
        {
            Console.WriteLine("Item B is running now!");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Menu m = new Menu("main Menu");
            m.AddMenuItem(new ItemA());
            m.AddMenuItem(new ItemB());
            m.ShowMenu();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuOS
{
    class Menu
    {
        private IMenuItem[] items;
        private int numItems;
        private const int MAX_ITEMS = 10;
        private string menuName;
        public Menu(string name)
        {
            this.menuName = name;
            this.numItems = 0;
            this.items = new IMenuItem[MAX_ITEMS];
        }

        public void AddMenuItem(IMenuItem item)
        {
            if (this.numItems < MAX_ITEMS)
                this.items[this.numItems++] = item;
        }

        public void ShowMenu()
        {
            int num = 0;
            while (num != this.numItems + 1)
            {
                Console.Clear();
                Console.WriteLine(this.menuName);
                Console.WriteLine();

                for (int i = 0; i < this.numItems; i++)
                {
                    Console.WriteLine($"{i + 1}. {this.items[i].MenuItemName()}");
                }
                Console.WriteLine($"{this.numItems + 1}. Exit");
                Console.Write("Choose which item to run:");
                string numString = Console.ReadLine();
                num = 0;
                int.TryParse(numString, out num);
                if (num > 0 && num <= this.numItems)
                {
                    Console.Clear();
                    this.items[num - 1].Run();
                }
            }
            
        }
    }
}

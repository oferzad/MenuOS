using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuOS
{
    interface IMenuItem
    {
        string MenuItemName();
        void Run();
    }
}

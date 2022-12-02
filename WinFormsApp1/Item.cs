using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    interface Item
    {
        int GetPrice();
    }

    internal class Cola : Item
    {
        public int GetPrice()
        { return 10; }
    }
    internal class kinly : Item
    {
        public int GetPrice()
        { return 5; }
    }
    internal class runner
    {
        public static void run()
        {
            Cola drink = new Cola();
            drink.GetPrice();

            kinly drink2 = new kinly();
            drink2.GetPrice();

        }
    }
    
}

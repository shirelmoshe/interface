using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_01_12_2022
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
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola drink = new Cola();
            drink.GetPrice();

            kinly drink2 = new kinly(); 
            drink2.GetPrice();  

        }
    }
}

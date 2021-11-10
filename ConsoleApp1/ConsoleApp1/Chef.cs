using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes Chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}


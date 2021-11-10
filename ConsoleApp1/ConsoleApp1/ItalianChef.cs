using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

    }
}

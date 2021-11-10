using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Movies avengers = new Movies("The Avengers", "Herry John", "Dog");
            Movies shrek = new Movies("Shrek", "Adam Adamson", "PG");
            // G, PG, PG-13, R, NR
            
            Console.WriteLine(shrek.Rating);
            Console.ReadLine();
                
        }
    }
}








    
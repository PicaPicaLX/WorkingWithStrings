using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = null;
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}

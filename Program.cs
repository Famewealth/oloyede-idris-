using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = " Polyilaro";
            // create variable name that accept integer,double and string input from the keyboard
            Console.WriteLine(" Enter The New Integer Value");
            int myint = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter The New Double Value");
            double mydouble = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Enter The New String Value");
           string mystring = Console.ReadLine();
            //concatinating and printing user input and constant data 
            Console.WriteLine( i + myint);
            Console.WriteLine( i +  mydouble);
            Console.WriteLine( s + " " + mystring );
            Console.ReadLine();
        }
    }
}

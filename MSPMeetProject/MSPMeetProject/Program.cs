using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPMeetProject
{
   public class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("All is well");
           int x = multiplication(10, 20);
            Console.WriteLine("multiplication is : " + x);
            Console.WriteLine("division is :" + division(20, 10));
            Console.Read();
        }

        public static int multiplication(int a, int b)
        {
            return a * b;
        }
        Console.WriteLine("All is well");
        public static int division(int a, int b)
        {
            if (b!=0)
            {
                return a / b;
            }
            else
            {
                return 0;
            }
        }
    }
}

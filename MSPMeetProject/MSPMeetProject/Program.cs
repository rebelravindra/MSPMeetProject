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
            Console.WriteLine("Addition is : " + (a + b));
           int x = multiplication(10, 20);
            Console.WriteLine("multiplication is : " + x);
            Console.Read();
        }

        public static int multiplication(int a, int b)
        {
            return a * b;
        }
    }
}

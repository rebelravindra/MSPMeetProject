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
            Console.WriteLine(armstrong(371));
            Console.Read();
        }

        public static int multiplication(int a, int b)
        {
            return a * b;
        }

        public static bool armstrong(int x)
        {
            int temp = x;
            int r, sum=0;
            while (x>0)
            {
                r = x % 10;
                sum = sum + r * r * r;
                x = x / 10;
            }
            if (sum == temp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Multplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=1;
            int num2=2;
            int num3=3;
            int num4=4;
            int num5=5;
            int num6=6;
            int num7=7;
            int num8=8;
            int num9=9;
            int num10=10;

            int numInput;
            int exitNum = -1;


            Console.Write("Pick any 2 Numbers between 1, and 10:");
            numInput = int.Parse(Console.ReadLine());

            while (numInput != exitNum)
            {
               
                if (numInput == num1)
                {
                    Console.WriteLine("Factors of {0}", numInput);
                    Console.WriteLine("1*1");
                    Console.Write("Would you like to exit?");
                    numInput = int.Parse(Console.ReadLine());
                }
                if (numInput == num2)
                {
                    Console.WriteLine("Factors of {0}", numInput);
                    Console.WriteLine("1*2");
                    Console.Write("Would you like to exit?");
                    numInput = int.Parse(Console.ReadLine());
                }
                if (numInput == num3)
                {
                    Console.WriteLine("Factors of {0}", numInput);
                    Console.WriteLine("1*3");
                    Console.Write("Would you like to exit?");
                    numInput = int.Parse(Console.ReadLine());
                }
                if (numInput == num4)
                {
                    Console.WriteLine("Factors of {0}", numInput);
                    Console.WriteLine("1*4");
                    Console.WriteLine("2*2");
                    Console.Write("Would you like to exit?");
                    numInput = int.Parse(Console.ReadLine());
                }
                if (numInput == num5)
                {
                    Console.WriteLine("Factors of {0}", numInput);
                    Console.WriteLine("1*5");
                    Console.Write("Would you like to exit?");
                    numInput = int.Parse(Console.ReadLine());
                }
                if (numInput == num6)
                {
                    Console.WriteLine("Factors of {0}", numInput);
                    Console.WriteLine("1*6");
                    Console.WriteLine("2*3");
                    Console.Write("Would you like to exit?");
                    numInput = int.Parse(Console.ReadLine());
                }
                if (numInput == num7)
                {
                    Console.WriteLine("Factors of {0}", numInput);
                    Console.WriteLine("1*7");
                    Console.Write("Would you like to exit?");
                    numInput = int.Parse(Console.ReadLine());
                }
                if (numInput == num8)
                {
                    Console.WriteLine("Factors of {0}", numInput);
                    Console.WriteLine("1*8");
                    Console.WriteLine("2*4");
                    Console.Write("Would you like to exit?");
                    numInput = int.Parse(Console.ReadLine());
                }
                if (numInput == num9)
                {
                    Console.WriteLine("Factors of {0}", numInput);
                    Console.WriteLine("3*3");
                    Console.WriteLine("1*9");
                    Console.Write("Would you like to exit?");
                    numInput = int.Parse(Console.ReadLine());
                }
                if (numInput == num10)
                {
                    Console.WriteLine("Factors of {0}", numInput);
                    Console.WriteLine("1*10");
                    Console.WriteLine("2*5");
                    Console.Write("Would you like to exit?");
                    numInput = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Those are All the factors of your numbers dude. r u happy now?");
        }
    }
}

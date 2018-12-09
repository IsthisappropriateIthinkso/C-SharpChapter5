using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            char initial = ' ';
            double salesPersonTotal=0;
            double salesPersonsGrandTotal=0;
            double sales;
            double highTotal=0;


            Console.WriteLine("Enter An Initial");
            initial = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Sales:");
            Console.WriteLine("Press (Z) To Stop");
            
            sales = double.Parse(Console.ReadLine());
            while (initial != 'Z' || initial != 'z')
            {
                if (initial == 'D' || initial == 'd' || initial == 'E' || initial == 'e' || initial == 'F' || initial == 'f')

                {
                    Console.WriteLine("Valid");
                }
                

            }
           while (initial == 'D' || initial == 'd' || initial == 'E' || initial == 'e' || initial == 'F' || initial == 'f'&&initial!='z' && initial != 'Z')
            {
                salesPersonTotal = salesPersonTotal + sales;
            }
        }
    }
}

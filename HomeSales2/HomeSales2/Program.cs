using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSales2
{
    class Program
    {
        static void Main(string[] args)
        {
            char spID = ' ';
            char exitInput = ' ';
            char exit = 'z' ;
            char Exit = 'Z';
            double salary;
            double total = 0;

            while (spID != 'F'|| spID != 'f' || spID != 'D' || spID != 'd' || spID != 'E' || spID != 'e')
            {

                Console.Write("Enter A Initial(F,D,E):");
                spID = char.Parse(Console.ReadLine());

                if (spID=='F'||spID=='f')
                {
                    Console.WriteLine("Initial is Valid");
                }
                if (spID == 'E' || spID == 'e')
                {
                    Console.WriteLine("Initial is Valid");
                }
                
                if (spID == 'D' || spID == 'd')
                {
                    Console.WriteLine("Initial is Valid");
                }
                else if (spID == 'e' )
                {
                    Console.WriteLine("INVALID {0}",spID);
                }

                while (exitInput != 'Z' || exitInput != 'z')
                {
                    Console.Write("Enter A Salary:");
                    salary = double.Parse(Console.ReadLine());

                    Console.Write("Enter Exit Input(Z)");
                    exitInput = char.Parse(Console.ReadLine());

                    if (exitInput=='Z'||exitInput=='z')
                    { 

                        

                        total = total + salary;
                       
                    }
                    Console.WriteLine("Salary:{0}", total);
                }
            }
        }
    }
}

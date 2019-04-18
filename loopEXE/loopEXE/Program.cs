using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopEXE
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            Console.WriteLine("Task 1");
            while (i < 6)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("X", i)));
                i++;
            }


            Console.WriteLine("");
            Console.WriteLine("Task 2");


            int aa = 1;
            Console.WriteLine("type a number large than 1...");
            int a = int.Parse(Console.ReadLine());

            while (aa <= a)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("X", aa)));
                aa++;
            }
            
                

            Console.WriteLine("");
            Console.WriteLine("Task 3");
            

            int ii = 5;

            while(ii > 0)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("X", ii)));
                ii = ii-1;
            }


            Console.WriteLine("");
            Console.WriteLine("Task 4");

            int bb = 1;
            Console.WriteLine("type a number between 1 and 10...");
            int b = int.Parse(Console.ReadLine());

            while (b >= bb)
            {

                Console.WriteLine(string.Concat(Enumerable.Repeat("X", b)));
                b= b-1;
            }

            Console.ReadKey();
       
        }
    }
}

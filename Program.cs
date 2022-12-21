using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inter the first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("rnter second number ");
            int n2 = int.Parse(Console.ReadLine());

            for(int i=n1; i<=n2; i++)
            {
                byte d = 0;
                for(int j=1;j<=i;j++)
                {
                    if (i % j == 0) 
                    {
                        d++;
                    }
                }
                if (d == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

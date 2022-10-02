using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//#nullable disable

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

           // string[] arr = new string[] { "x", "o" };
            char[] arr = new char[] { 'x', 'o' };
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j <= 3; j++)
                    {
                        for (int l = 1; l > -1; l--)
                        {
                            Console.Write(arr[l]);
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int k = 0; k <= 3; k++)
                    {
                        for (int m = 0; m <= 1; m++)
                        {
                            Console.Write(arr[m]);
                        }
                    }
                    Console.WriteLine();
                    
                }
            }
        }
    }
}

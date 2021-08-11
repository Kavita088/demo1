using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int divisor = 0;
            try
            {
                int output = n1 / divisor;
            }
            catch (DivideByZeroException)
            {
                System.Console.WriteLine("not possible to divide by zero");
            }
            finally
            {
                System.Console.WriteLine("finally exception");
                System.Console.ReadKey();
            }
        }
    }
}
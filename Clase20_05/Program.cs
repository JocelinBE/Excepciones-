using System;

namespace Clase20_05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.ReadLine();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch(FormatException a)
            {
                Console.WriteLine(a.Message);
                Console.WriteLine(a.StackTrace);
            }
            Console.ReadKey();

        }
       
    }
}

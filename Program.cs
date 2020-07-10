using System;
using System.Data;
using System.Dynamic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter mathematical expression as an input");
            String value = Console.ReadLine();
            try
            {
                var result = new DataTable().Compute(value, null);
                Console.WriteLine("result = " + result);
            }
            catch(Exception exeption)
            {
                Console.WriteLine(
                    $"Incorrect input: {exeption.Message}");
            }
            Console.ReadLine();
              

        }
    }
}

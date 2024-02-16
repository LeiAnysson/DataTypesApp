using System;
namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int pieces = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the total price of " + pieces +  " apple(s): ");
            double total = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total price of " + pieces + " apple(s) is " + total);
            Console.WriteLine("The value of original price is " + total);
            int cnv = (int)total;
            Console.WriteLine("The value of converted price is " + cnv);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}

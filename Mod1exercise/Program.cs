namespace Mod1exercise
{
 
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Product class
            Product product = new Product();

            // Read input from the user
            product.ReadInput();

            // Print the receipt
            product.PrintReceipt();

            // Wait for the user to press a key before exiting
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
using System;

namespace Mod1exercise
{
 
        public class Product
        {
            // Fields to store product details
            private string productName = string.Empty;
            private int quantity = 0;
            private double pricePerUnit = 0.0;

            // Method to read input from the user
            public void ReadInput()
            {
                Console.WriteLine("Welcome to my shop!");

                // Ensure valid product name
                Console.Write("Name of the product? ");
                productName = Console.ReadLine() ?? string.Empty;

                while (string.IsNullOrWhiteSpace(productName))
                {
                    Console.WriteLine("Product name cannot be empty. Please enter a valid product name.");
                    Console.Write("Name of the product? ");
                    productName = Console.ReadLine() ?? string.Empty;
                }

                Console.WriteLine($"You picked {productName}!");

                // Read and validate price input
                Console.Write("Price? ");
                string priceInput = Console.ReadLine() ?? string.Empty;

                if (double.TryParse(priceInput, out pricePerUnit) == false)
                {
                    Console.WriteLine("Invalid price. Exiting.");
                    return;
                }
                Console.WriteLine($"The price of {productName} is {pricePerUnit:F2}.");

                // Read and validate quantity input
                Console.Write("Quantity of the product? ");
                string quantityInput = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(quantityInput, out quantity) == false)
                {
                    Console.WriteLine("Invalid quantity. Exiting.");
                    return;
                }
                Console.WriteLine($"The number of this product is {quantity}.");
            }

            // Method to calculate the total price
            public double CalculateTotalPrice()
            {
                return quantity * pricePerUnit;
            }

            // Method to print the receipt
            public void PrintReceipt()
            {
                double totalPrice = CalculateTotalPrice();
                Console.WriteLine("\n***** Receipt *****");
                Console.WriteLine($"Product       : {productName}");
                Console.WriteLine($"Unit price    : {pricePerUnit:F2}");
                Console.WriteLine($"Quantity      : {quantity}");
                Console.WriteLine($"Amount to pay : {totalPrice:F2}");
                Console.WriteLine("***** Welcome back! *****");
            }
        }
    }

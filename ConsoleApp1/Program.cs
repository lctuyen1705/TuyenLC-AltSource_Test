using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class Product
        {
            public string No { get; set; }
            public string Category { get; set; }
            public string Price { get; set; }
            public bool IsVendor { get; set; }

        }

        static void Main(string[] args)
        {
            string postion = string.Empty;
            bool isCorrect = true;

            var listProduct = new List<Product>();

            listProduct.Add(new Product { No = "TS", Category = "T-Shirt", Price = "$6", IsVendor = true });
            listProduct.Add(new Product { No = "DS", Category = "Dress-Shirt", Price = "$8", IsVendor = true });

            listProduct.Add(new Product { No = "TS", Category = "T-Shirt", Price = "$12", IsVendor = false });
            listProduct.Add(new Product { No = "DS", Category = "Dress-Shirt", Price = "$20", IsVendor = false });

            string[] sizes = { "M", "L", "XL" };
            string[] colors = { "Red", "Blue" };

            var listSize = new List<string>(sizes);
            var listColor = new List<string>(colors);

            var product = string.Empty;
            var price = string.Empty;
            var size = string.Empty;
            var color = string.Empty;


            Console.WriteLine("Are you Vendor, Suppiler or Customer (V/S/C)?");
            postion = Console.ReadLine();

            if (postion.Contains("S"))
            {
                isCorrect = false;

                Console.WriteLine("Do you want add new product");
                product = Console.ReadLine();
                listProduct.Add(new Product { No = "1", Category = "T-Shirt", Price = "$6", IsVendor = true });
            }

            if (postion.Contains("V"))
            {
                Console.WriteLine("Which category of clother you to buy :");
                foreach (var ca in listProduct)
                {
                    if (ca.IsVendor)
                    {
                        Console.WriteLine("{0} - {1} - {2}", ca.No, ca.Category, ca.Price);
                        Console.WriteLine();
                    }
                }
                product = Console.ReadLine();

                if (product.Contains("TS"))
                {
                    product = "T-Shirt";
                    price = "$6";
                }
                else if (product.Contains("DS"))
                {
                    product = "Dress-Shirt";
                    price = "$8";
                }
                else
                {
                    isCorrect = false;
                }

                Console.WriteLine("Which size of clother you to buy :");
                foreach (var s in listSize)
                {
                    Console.WriteLine("{0}", s);
                    Console.WriteLine();
                }
                size = Console.ReadLine();

                if (size.Contains("M"))
                {
                    size = "M";
                }
                else if (size.Contains("L"))
                {
                    size = "L";
                }
                else if (size.Contains("XL"))
                {
                    size = "XL";
                }
                else
                {
                    isCorrect = false;
                }

                Console.WriteLine("Which color of clother you to buy :");
                foreach (var co in listColor)
                {
                    Console.WriteLine("{0}", co);
                    Console.WriteLine();
                }
                color = Console.ReadLine();

                if (color.Contains("Red"))
                {
                    color = "Red";
                }
                else if (color.Contains("Blue"))
                {
                    color = "Blue";
                }
                else
                {
                    isCorrect = false;
                }
            }

            if (postion.Contains("C"))
            {
                Console.WriteLine("------Hello Customer------");
                Console.WriteLine("Which category of clother you to buy :");
                foreach (var ca in listProduct)
                {
                    if (!ca.IsVendor)
                    {
                        Console.WriteLine("{0} - {1} - {2}", ca.No, ca.Category, ca.Price);
                        Console.WriteLine();
                    }
                }
                product = Console.ReadLine();

                if (product.Contains("TS"))
                {
                    product = "T-Shirt";
                    price = "$12";
                }
                else if (product.Contains("DS"))
                {
                    product = "Dress-Shirt";
                    price = "$20";
                }
                else
                {
                    isCorrect = false;
                }

                Console.WriteLine("Which size of clother you to buy :");
                foreach (var s in listSize)
                {
                    Console.WriteLine("{0}", s);
                    Console.WriteLine();
                }
                size = Console.ReadLine();

                if (size.Contains("M"))
                {
                    size = "M";
                }
                else if (size.Contains("L"))
                {
                    size = "L";
                }
                else if (size.Contains("XL"))
                {
                    size = "XL";
                }
                else
                {
                    isCorrect = false;
                }

                Console.WriteLine("Which color of clother you to buy :");
                foreach (var co in listColor)
                {
                    Console.WriteLine("{0}", co);
                    Console.WriteLine();
                }
                color = Console.ReadLine();

                if (color.Contains("Red"))
                {
                    color = "Red";
                }
                else if (color.Contains("Blue"))
                {
                    color = "Blue";
                }
                else
                {
                    isCorrect = false;
                }
            }


            if (isCorrect)
            {
                Console.WriteLine("Your {0} have size is {1} and color is {2} with price {3}, Thank you!", product, size, color, price);
            }
            else
            {
                Console.WriteLine("Please check your value when you choosed and try again!");
            }


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

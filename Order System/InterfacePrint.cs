using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_System
{
    public class InterfacePrint
    {
        public void menuOptions()
        {
            Console.WriteLine("Menu:[1] Customer");
            Console.WriteLine("Menu:[2] Order");
            Console.WriteLine("Menu:[3] Order Item");
            Console.WriteLine("Menu:[4] Product");
            Console.WriteLine("Menu:[5] Report");
            Console.WriteLine("Menu:[6] Quit the program");
        }
        public void menuControl()

        {
            int menuOption = int.Parse(Console.ReadLine());
            bool menuQuit = true;

            while (menuQuit)
            {
                switch (menuOption)
                {
                    case 1:
                        {
                            Console.WriteLine("Menu:[1] Customer");
                            Console.WriteLine("Menu:[1] [1] New Customer; [2] Delete Customer");
                            int customerAction = int.Parse(Console.ReadLine());

                            switch (customerAction)
                            {
                                case 1:
                                    Console.WriteLine("[1] Customer Id");
                                    string customerId = Console.ReadLine();
                                    Console.WriteLine("[2] Customer Name");
                                    int customerName = int.Parse(Console.ReadLine());
                                    Console.WriteLine("[3] Customer Payment Amount");
                                    int customerPaymentAmount = int.Parse(Console.ReadLine());
                                    Console.WriteLine("[4] Customer Payment Conditions");
                                    int customerPaymentConditions = int.Parse(Console.ReadLine());
                                    break;
                                case 2:
                                    Console.WriteLine("[2] Enter Customer Id to Delete");
                                    string customerIdDelete = (Console.ReadLine());
                                    break;
                                default:
                                    {
                                    Console.WriteLine("Choosen wrong parameter");
                                    break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Menu:[2] Order");
                            Console.WriteLine("Menu:[2] [1] New Order; [2] Delete Order");
                            int orderAction = int.Parse(Console.ReadLine());
                            switch (orderAction)
                            {
                                case 1:
                                    Console.WriteLine("[1] Customer Id");
                                    string customerId = Console.ReadLine();
                                    Console.WriteLine("[2] Order Number");
                                    int orderNumber = int.Parse(Console.ReadLine());
                                    Console.WriteLine("[3] Order date");
                                    int orderdate = int.Parse(Console.ReadLine());
                                    Console.WriteLine("[4] Order Amount");
                                    int orderAmount = int.Parse(Console.ReadLine());
                                    break;
                                case 2:
                                    Console.WriteLine("[2] Enter Order number to Delete");
                                    string ordernumberDelete = (Console.ReadLine());
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Choosen wrong parameter");
                                        break;
                                    }
                            }
                            break;
                            
                        }
                    case 3:
                        {
                            Console.WriteLine("Menu:[3] Order Item");
                            Console.WriteLine("Menu:[3] [1] New Order Item; [2] Delete Order Item");
                            int orderItemAction = int.Parse(Console.ReadLine());
                            switch (orderItemAction)
                            {
                                case 1:
                                    Console.WriteLine("[1] Order Number");
                                    int orderNumber = int.Parse(Console.ReadLine());
                                    Console.WriteLine("[2] Product Id");
                                    int productId = int.Parse(Console.ReadLine());
                                    Console.WriteLine("[3] Quantity");
                                    decimal quantity = decimal.Parse(Console.ReadLine());
                                    break;
                                case 2:
                                    Console.WriteLine("[2] Enter Order number to Delete");
                                    string ordernumberDelete = (Console.ReadLine());
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Choosen wrong parameter");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Menu:[4] Product");
                            Console.WriteLine("Menu:[4] [1] New Product; [2] Delete Product");
                            int productAction = int.Parse(Console.ReadLine());

                            switch (productAction)
                            {
                                case 1:
                                    Console.WriteLine("[1] Product Id");
                                    int productId = int.Parse(Console.ReadLine());
                                    Console.WriteLine("[2] Product Name");
                                    int productName = int.Parse(Console.ReadLine());
                                    Console.WriteLine("[3] ProductDescription");
                                    decimal productDescription = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("[4] ProductPrice");
                                    decimal productPrice = decimal.Parse(Console.ReadLine());
                                    Console.WriteLine("[5] UnitOfMeasurement");
                                    decimal balance = decimal.Parse(Console.ReadLine());
                                    break;
                                case 2:
                                    Console.WriteLine("[2] Enter Product Id to Delete");
                                    string productIddetele = (Console.ReadLine());
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Choosen wrong parameter");
                                        break;
                                    }
                            }
                            break;

                        }
                    case 5:
                        {
                            Console.WriteLine("Menu:[5] Report");
                            Console.WriteLine("Menu:[5]  [1] All Client Report; [2] All unpaid orders Report");
                            int reportAction = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Menu:[6] Quit the program");
                            menuQuit = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Choosen wrong parameter");
                            menuQuit = false;
                            break;
                        }
                }
                if (menuOption == 1 || menuOption == 2 || menuOption == 3 || menuOption == 4 || menuOption == 5)
                {
                    menuOptions();
                    menuOption = int.Parse(Console.ReadLine());
                }
            }

        }

    }
}

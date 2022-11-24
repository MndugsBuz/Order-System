using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order_System.Repositories;
using Order_System.Entities;

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

            OrdersRepository ordersRepository = new OrdersRepository();
            ordersRepository.ReadFromJson();
            CustomerRepository customersRepository = new CustomerRepository();
            customersRepository.ReadFromJson();
            OrderItemRepository orderItemsRepository = new OrderItemRepository();
            orderItemsRepository.ReadFromJson();
            ProductRepository productRepository = new ProductRepository();
            productRepository.ReadFromJson();


            while (menuQuit)
            {
                switch (menuOption)
                {
                    case 1:
                        {
                            Console.WriteLine("Menu:[1] Customer");
                            Console.WriteLine("Menu:[1] [1] New Customer; [2] Delete Customer; [3] List current customers");
                            int customerAction = int.Parse(Console.ReadLine());
                            
                            switch (customerAction)
                            {
                                case 1:
                                    customersRepository.AddCustomer();
                                    break;
                                case 2:
                                    customersRepository.DeteleCustomer();
                                    break;
                                case 3:
                                    customersRepository.PrintCustomers();
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
                            Console.WriteLine("Menu:[2] [1] New Order; [2] Delete Order [3] List current orders");
                            int orderAction = int.Parse(Console.ReadLine());
                            switch (orderAction)
                            {
                                case 1:
                                    ordersRepository.AddOrder();
                                    break;
                                case 2:
                                    ordersRepository.DeleteOrder();
                                    break;
                                case 3:
                                    ordersRepository.PrintOrders();
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
                            Console.WriteLine("Menu:[3] [1] New Order Item; [2] Delete Order Item [3] List current order Items");
                            int orderItemAction = int.Parse(Console.ReadLine());
                            
                            switch (orderItemAction)
                            {
                                case 1:
                                    orderItemsRepository.AddOrderItem();
                                    break;
                                case 2:
                                    orderItemsRepository.DeleteOrderItem();
                                    break;
                                case 3:
                                    orderItemsRepository.PrintOrderItems();
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
                                    productRepository.AddProduct();
                                    break;
                                case 2:
                                    productRepository.DeleteProduct();
                                    break;
                                case 3:
                                    productRepository.PrintProducts();
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
                            Console.WriteLine("Menu:[5]  [1] All Clients Report; [2] All unpaid orders Report");
                            int reportAction = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Menu:[6] Quit the program");
                            menuQuit = false;
                            customersRepository.WriteToJson();
                            ordersRepository.WriteToJson();
                            orderItemsRepository.WriteToJson();
                            productRepository.WriteToJson();
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

using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;
using System.Threading;
using System.Linq;

namespace PizzaBox.Client
{

    class Program
    {
        /// <summary>
        /// Instantiate the controllers each DBSet.
        /// These map back to the Repo and Repo Interfaces to perform CRUD operations
        /// </summary>
        /// <returns></returns>
        public static StoreController storeController = new StoreController();
        public static PizzaController pizzaController = new PizzaController();
        public static OrderController orderController = new OrderController();
        public static ComponentController componentController = new ComponentController();
        public static CustomerController customerController = new CustomerController();

        /// <summary>
        /// Entry point of program.  
        /// This is the primary loop of program and contains Main Menu switch
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int menuSelection;
            do 
            {
                DisplayMainMenu();
                menuSelection = GetInputInt();

                switch(menuSelection)
                {
                    // Create order in Pittsburgh
                    case 1:
                        Console.Clear();
                        Pittsburgh pittsburgh = new Pittsburgh();
                        CreateOrder(pittsburgh);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.ResetColor();
                        break;

                    // Create order in Tampa Bay
                    case 2: 
                        Console.Clear();
                        TampaBay tampaBay = new TampaBay();
                        CreateOrder(tampaBay);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.ResetColor();
                        break;

                    // Display order status at the stores
                    case 3:
                        Console.Clear();
                        DisplayOrders();
                        System.Console.WriteLine("\nThis function is not yet completed");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n\nPress enter to go back to the main menu");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;

                    // For store owner to view Pittsburg info
                    case 7:
                        Console.Clear();
                        Pittsburgh pitt = new Pittsburgh();
                        DisplayStoreInfo(pitt);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n\nPress enter to go back to the main menu");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;

                    // For store owner to view Tampa Bay info
                    case 8:
                        Console.Clear();
                        TampaBay tampa = new TampaBay();
                        DisplayStoreInfo(tampa);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n\nPress enter to go back to the main menu");
                        Console.ResetColor();
                        Console.ReadLine();                    
                        break;

                    // Use 99 to end program
                    case 99:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\nThank you for using the Pizza Box App!");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        break;

                    // Send error message to client if they add malformed input                  
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n\nInvalid selection.  Please try again\n\n");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        break;
                }
            } while (menuSelection != 99);
        }


        /// <summary>
        /// This method enables client to order pizza via sub-menu.
        /// Customer can order preset pizzas or custom pizza.
        /// They also have option to modify their order.
        /// </summary>
        /// <param name="store"></param>
        public static void CreateOrder(AStore store)
        {
            // Set up variables and instantiate objects
            Customer customer = new Customer();
            Order order = new Order();
            string customerName = string.Empty;
            int menuSelection = 0;
            customer.Name = GetInputStr();
            customerController.AddCustomer(customer);
            order.Customer = customer;
            order.Store = store;

            System.Console.WriteLine("\n");               
            do
            {
                DisplayPizzaMenu();
                menuSelection = GetInputInt();
                switch(menuSelection)
                {
                    // Order a cheese pizza
                    case 1:
                        order.Pizzas.Add(new CheesePizza());
                        DisplayOrderStatus(order);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n\nPress enter to return to the pizza selection menu");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;

                    // Order a veggie pizza
                    case 2:
                        order.Pizzas.Add(new VeggiePizza());
                        DisplayOrderStatus(order);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n\nPress enter to return to the pizza selection menu");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;

                    // Order a meat pizza
                    case 3:
                        order.Pizzas.Add(new MeatPizza());
                        DisplayOrderStatus(order);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n\nPress enter to return to the pizza selection menu");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;

                    // Order a custom pizza                       
                    case 4:
                        //CreateCustomPizza();
                        System.Console.WriteLine("This function is not yet implemented");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n\nPress enter to return to the pizza selection menu");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;

                    // Remove a pizza from the current order
                    case 5:
                        RemovePizzaFromOrder(order);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n\nPress enter to return to the pizza selection menu");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;

                    // Submit the order to orderController where it is committed to DB
                    case 6:
                        // function to save all data
                        // LockOrder(order);
                        System.Console.WriteLine("This funcion is not yet implemented");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n\nPress enter to return to the pizza selection menu");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;

                    // Exit to main menu
                    case 99:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\nThank you for your order!");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        break;

                    // in case of bad input, inform user
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n\nInvalid selection.  Please try again\n\n");
                        Console.ResetColor();
                        Thread.Sleep(1000);
                        break;
                }
            } while (menuSelection != 99);
        }

        /// <summary>
        /// Bring in the order and print menu of current pizzas on the order.
        /// Give client abiilty to delete a pizza from the order.
        /// </summary>
        /// <param name="order"></param>
        public static void RemovePizzaFromOrder(Order order)
        {
            int menuSelection = 0;
            while (menuSelection != 99)
            {
                System.Console.WriteLine("\nThese pizzas are currently in your order:\n");
                int count = 0;
                foreach(var pizza in order.Pizzas)
                {
                    System.Console.WriteLine($"{count}) {pizza.Name}");
                    count++;
                }
                System.Console.WriteLine("99) Exit the order editor.\n");

                menuSelection = GetInputInt();
                
                if (menuSelection < order.Pizzas.Count && menuSelection >= 0)
                {
                    order.Pizzas.Remove(order.Pizzas.ElementAt(menuSelection));
                }
            };
        }

        /// <summary>
        /// Commit the order to orderController, where it will update the DB
        /// </summary>
        /// <param name="order"></param>
        public static void LockOrder(Order order)
        {
            try
            {
                orderController.AddOrder(order);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Error in LockOrder function");
                System.Console.WriteLine($"{ex}");
            }
        }

        /// <summary>
        /// Create menu to allow customer to build custom pizza
        /// Will have option for Crust, Size, and Toppings
        /// </summary>
        public static void CreateCustomPizza()
        {
            // order.Pizzas.Add(new CustomPizza());
        }
        
        /// <summary>
        /// Bring in the customer's current order and display the user name, store name, and list each pizza
        /// Toppings and price will be listed with each pizza
        /// </summary>
        /// <param name="order"></param>
        public static void DisplayOrderStatus(Order order)
        {
            System.Console.WriteLine("\n\n");
            System.Console.WriteLine("\nYour Order so far:\n ");

            decimal totalPrice = 0;
            System.Console.WriteLine($"Name: {order.Customer.Name}");
            System.Console.WriteLine($"Store: {order.Store.Name}");

            foreach(APizza pizza in order.Pizzas)
            {
                System.Console.WriteLine($"Pizza: {pizza.Name}");
                foreach(AComponent component in pizza.AComponents)
                {
                    System.Console.WriteLine($"\t{component.Name, 5} {component.Price}");
                    totalPrice += component.Price;

                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine($"Total Price: {totalPrice}");
            Console.ResetColor();
        }

        /// <summary>
        /// Bring in Store object and display all orders at that store
        /// </summary>
        /// <param name="store"></param>
        public static void DisplayStoreInfo(AStore store)
        {
            var orders = orderController.GetOrders();
            var stores = storeController.GetStores();
            var pizzas = pizzaController.GetPizzas();
            var customers = customerController.GetCustomers();

            var ordStoreJoin = orders.Join(stores,
                orders => orders.StoreId,
                stores => stores.AStoreId,
                (orders, stores) => new
                    {
                        StoreName = stores.Name,
                        OrderNum = orders.AOrderId,
                        OrderPizza = orders.PizzaId,
                        OrderCust = orders.CustomerId
                    }).Where(x => x.StoreName == store.Name).ToList();
                    
            var pizzaJoin = pizzas.Join(ordStoreJoin,
                pizzas => pizzas.APizzaId,
                ordStoreJoin => ordStoreJoin.OrderPizza,
                (pizzas, ordStoreJoin) => new
                {
                    StoreName = ordStoreJoin.StoreName,
                    OrderNum = ordStoreJoin.OrderNum,
                    PizzaName = pizzas.Name,
                    OrderCust = ordStoreJoin.OrderCust
                }).ToList();
            
            var custJoin = customers.Join(pizzaJoin,
                customers => customers.ACustomerId,
                pizzaJoin => pizzaJoin.OrderCust,
                (customers, pizzaJoin) => new
                {
                    StoreName = pizzaJoin.StoreName,
                    PizzaName = pizzaJoin.PizzaName,
                    CustomerName = customers.Name
                }).OrderByDescending(x => x.StoreName);
            
            System.Console.WriteLine($"Store Name\tCustomer Name\tPizza Name");
            foreach(var x in custJoin)
            {
                System.Console.WriteLine($"{x.StoreName}\t{x.CustomerName}\t{x.PizzaName}");
            } 
        }        
        

        /// <summary>
        /// Display orders at both stores to see full list
        /// </summary>
        public static void DisplayOrders()
        {
            var stores = storeController.GetStores();
            foreach(AStore store in stores)
            {
                System.Console.WriteLine($"{store.Name}");
                foreach(Order ord in store.AOrders)
                {
                    System.Console.WriteLine($"Customer Number: {ord.Customer.ACustomerId}");
                    int count = 0;
                    foreach(APizza pizza in ord.Pizzas)
                    {
                        count++;
                        System.Console.WriteLine($"{count}) {pizza.Name}");
                    }
                }
            }
        }


/// <summary>
/// //////////////////////////////////  Menus and Input Section //////////////////////////////////////////////////
/// Int and Str Input will do validation first
/// Menus are driven by int's.
/// String input is used for customer name.
/// </summary>
/// <returns></returns>

        static int GetInputInt()
        {
            int value = 0;
            string input = string.Empty;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Please enter a selection: ");
                input = Console.ReadLine();
                Console.ResetColor();
            } while (!int.TryParse(input, out value));

            return value;
        }

        static string GetInputStr()
        {
            string input = string.Empty;
            do 
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                System.Console.Write("\n\tPlease enter your name: ");
                input = Console.ReadLine();
                Console.ResetColor();
            } while (String.IsNullOrWhiteSpace(input));

            return input;
        }

        static void DisplayMainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n\nWelcome to the Pizza Box App\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Main Menu");
            Console.ResetColor();
            System.Console.WriteLine("Customer Menu:");
            Console.WriteLine($"\t1) Order A Pizza from Pittsburgh");
            Console.WriteLine($"\t2) Order A Pizza from Tampa");
            Console.WriteLine($"\t3) View current orders");
            System.Console.WriteLine("\nStore Owner Menu:");
            Console.WriteLine($"\t7) View Pittsburgh Info");
            Console.WriteLine($"\t8) View Tampa Store Info");
            Console.WriteLine($"\n\t99) Exit App");
            Console.WriteLine();
        }

        public static void DisplayPizzaMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("Our Pizza Listing\n");
            var pizzas = pizzaController.GetPizzas();

            int count = 1;
            foreach(APizza pizza in pizzas)
            {
                System.Console.WriteLine($"\t{count}) {pizza.Name}");
                count++;
            }

            System.Console.WriteLine("\t5) Edit your order");
            System.Console.WriteLine("\t6) Lock-in your order!");
            System.Console.WriteLine("\t99) Go back to Main Menu");
        }
        

    }

}


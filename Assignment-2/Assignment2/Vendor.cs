using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Vendor
    {
        static void Main(string[] args)
        {
            int balance = 1000;

        //Initalizing objects and their values
            Item Snickers = new Item("Snickers", 10, 100);
            Item Coke = new Item("Coke", 50, 100);
            Item Fritos = new Item("Fritos", 1000, 100);
            Item Pizza = new Item("Pizza", 40, 100);
            Item PizzaRolls = new Item("Pizza Rolls", 1, 1);

            //Placing items into the 'items' array
            Item[] items = { Snickers, Coke, Fritos, Pizza, PizzaRolls };


        /* Used this as a reference
         * https://stackoverflow.com/questions/43484523/switch-statements-for-a-menu-c
         * 
         * Menu:
         */
        bool run = true;
            while(run)
            {
                //Displaying the menu
                if(balance > 0)
                {

                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}):{items[i].ItemName}, Price: {items[i].Price}, Quantity: {items[i].Quantity}");
                    }
                        Console.WriteLine("Exit (e)");
                    Console.WriteLine($"You have {balance}$ How would you like to spend it?");

                    //menu option input
                    string menu = Console.ReadLine();
                    switch (menu)
                    {
                        case "1":
                            Console.WriteLine($"How many {items[0].ItemName}'s would you like to purchase?");
                            string amount = Console.ReadLine();
                            if (int.Parse(amount) <= items[0].Quantity)
                            {
                                if(balance >= items[0].Price)
                                {
                                    Console.WriteLine($"The total amount of your purchase is: {items[0].Price * int.Parse(amount)} is this ok? Y/N");
                                    string confirm = Console.ReadLine();
                                    if(confirm == "Y" || confirm == "y")
                                    {
                                        Console.WriteLine("Thank you for your business!");
                                        items[0].Quantity -= int.Parse(amount);
                                        balance -= (items[0].Price * int.Parse(amount));
                                    }
                                    else
                                    {
                                        break;  
                                    }

                                }
                            }
                            else if (int.Parse(amount) > items[0].Quantity)
                            {
                                Console.WriteLine($"We don't have that many {items[0].ItemName}'s in stock. Please enter a different amount.");
                            }
                            break;
                        case "2":
                            Console.WriteLine($"How many {items[1].ItemName}'s would you like to purchase?");
                            amount = Console.ReadLine();
                            if (int.Parse(amount) <= items[1].Quantity)
                            {
                                if (balance >= items[1].Price)
                                {
                                    Console.WriteLine($"The total amount of your purchase is: {items[1].Price * int.Parse(amount)} is this ok? Y/N");
                                    string confirm = Console.ReadLine();
                                    if (confirm == "Y" || confirm == "y")
                                    {
                                        Console.WriteLine("Thank you for your business!");
                                        items[1].Quantity -= int.Parse(amount);
                                        balance -= (items[1].Price * int.Parse(amount));
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }
                            }
                            else if (int.Parse(amount) > items[1].Quantity)
                            {
                                Console.WriteLine($"We don't have that many {items[1].ItemName}'s in stock. Please enter a different amount.");
                            }
                            break;
                        case "3":
                            Console.WriteLine($"How many {items[2].ItemName}'s would you like to purchase?");
                            amount = Console.ReadLine();
                            if (int.Parse(amount) <= items[2].Quantity)
                            {
                                if (balance >= items[2].Price)
                                {
                                    Console.WriteLine($"The total amount of your purchase is: {items[2].Price * int.Parse(amount)} is this ok? Y/N");
                                    string confirm = Console.ReadLine();
                                    if (confirm == "Y" || confirm == "y")
                                    {
                                        Console.WriteLine("Thank you for your business!");
                                        items[2].Quantity -= int.Parse(amount);
                                        balance -= (items[2].Price * int.Parse(amount));
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }
                            }
                            else if (int.Parse(amount) > items[2].Quantity)
                            {
                                Console.WriteLine($"We don't have that many {items[2].ItemName}'s in stock. Please enter a different amount.");
                            }
                            break;
                        case "4":
                            Console.WriteLine($"How many {items[3].ItemName}'s would you like to purchase?");
                            amount = Console.ReadLine();
                            if (int.Parse(amount) <= items[3].Quantity)
                            {
                                if (balance >= items[3].Price)
                                {
                                    Console.WriteLine($"The total amount of your purchase is: {items[3].Price * int.Parse(amount)} is this ok? Y/N");
                                    string confirm = Console.ReadLine();
                                    if (confirm == "Y" || confirm == "y")
                                    {
                                        Console.WriteLine("Thank you for your business!");
                                        items[3].Quantity -= int.Parse(amount);
                                        balance -= (items[3].Price * int.Parse(amount));
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }
                            }
                            else if (int.Parse(amount) > items[3].Quantity)
                            {
                                Console.WriteLine($"We don't have that many {items[3].ItemName}'s in stock. Please enter a different amount.");
                            }
                            break;
                        case "5":
                            Console.WriteLine($"How many {items[4].ItemName}'s would you like to purchase?");
                            amount = Console.ReadLine();
                            if (int.Parse(amount) <= items[4].Quantity)
                            {
                                if (balance >= items[4].Price)
                                {
                                    Console.WriteLine($"The total amount of your purchase is: {items[4].Price * int.Parse(amount)} is this ok? Y/N");
                                    string confirm = Console.ReadLine();
                                    if (confirm == "Y" || confirm == "y")
                                    {
                                        Console.WriteLine("Thank you for your business!");
                                        items[4].Quantity -= int.Parse(amount);
                                        balance -= (items[4].Price * int.Parse(amount));
                                    }
                                    else
                                    {
                                        break;
                                    }

                                }
                            }
                            else if (int.Parse(amount) > items[4].Quantity)
                            {
                                Console.WriteLine($"We don't have that many {items[4].ItemName}'s in stock. Please enter a different amount.");
                            }
                            break;
                        case "e":
                            run = false;
                            break;
                        default:
                            Console.WriteLine("That was not an option, Please try one of the following inputs in the menu");
                            break;
                            
                    }
                }
                else
                {
                    Console.WriteLine("You dont have any money");
                    return;
                }
            }
                


        }
    }
}
